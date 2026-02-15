using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using TrafficSensors.Bus.BusApi;
using TrafficSensors.Bus.Model;
using TrafficSensors.DB.DataDb;
using TrafficSensors.DB.DataDb.Model;
using TrafficSensors.DB.SensorsDb;
using SensorModel = TrafficSensors.DB.SensorsDb.Model.Sensor;

namespace TrafficSensors.Service.ReportsApi.Controllers
{
    [Route("/reports-api")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private IBusApi _busApi { get; set; }
        private SensorsDataDatabaseContext _sensorsDataDatabase { get; set; }
        private SensorDatabaseContext _sensorsRegistrationDatabase { get; set; }
        private string _serviceGuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="busApi"></param>
        /// <param name="sensorsDataDb"></param>
        /// <param name="sensorsRegistrationDb"></param>
        /// <param name="configuration"></param>
        public ApiController(IBusApi busApi, SensorsDataDatabaseContext sensorsDataDb, SensorDatabaseContext sensorsRegistrationDb, IConfiguration configuration)
        {
            _busApi = busApi;
            _sensorsDataDatabase = sensorsDataDb;
            _sensorsRegistrationDatabase = sensorsRegistrationDb;
            _serviceGuid = configuration["AppSettings:ServiceGuid"];
        }

        /// <summary>
        /// Called periodically (about every 1 minute)
        /// </summary>
        public void ProcessJob()
        {
            _busApi.Subscribe(_serviceGuid, SubscribeEventType.SensorRegistration);
            _busApi.Subscribe(_serviceGuid, SubscribeEventType.SensorData);

            var sensorRegistrations = _busApi.Read(_serviceGuid, SubscribeEventType.SensorRegistration);
            if (sensorRegistrations != null)
            {
                foreach (var item in sensorRegistrations.OfType<SensorRegistration>())
                {
                    _sensorsRegistrationDatabase.Sensors.Add(new SensorModel
                    {
                        SensorGuid = item.SensorGuid,
                        GPSLocalization = item.GPSLocalization,
                        SensorSpecialization = item.Specialization,
                        RegistrationTime = item.RegistrationTime
                    });
                }
                _sensorsRegistrationDatabase.SaveChanges();
            }

            var sensorData = _busApi.Read(_serviceGuid, SubscribeEventType.SensorData);
            if (sensorData != null)
            {
                foreach (var item in sensorData.OfType<SensorData>())
                {
                    _sensorsDataDatabase.DetectedData.Add(new DetectedData
                    {
                        DataGuid = item.DataGuid,
                        SensorGuid = item.SensorGuid,
                        DetectionTime = item.DetectionTime,
                        NumberOfContacts = item.NumberOfContacts
                    });
                }
                _sensorsDataDatabase.SaveChanges();
            }
        }
    }
}

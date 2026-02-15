using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using TrafficSensors.Bus.BusApi;
using TrafficSensors.Bus.Model;
using TrafficSensors.DB.SensorsDb;
using TrafficSensors.Sensor.Type;

namespace TrafficSensors.Service.SensorsApi.Controllers
{
    [Route("/sensors-api")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private IBusApi _busApi { get; set; }
        private SensorDatabaseContext _sensorDatabase { get; set; }

        public string _serviceGuid { get; private set; }

        public ApiController(IBusApi busApi, SensorDatabaseContext db, IConfiguration configuration)
        {
            _busApi = busApi;
            _sensorDatabase = db;
            // serwis GUID required by IBusApi
            _serviceGuid = configuration["AppSettings:ServiceGuid"];
        }
    }
}

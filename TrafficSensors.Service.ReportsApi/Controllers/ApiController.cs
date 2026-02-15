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
using TrafficSensors.DB.SensorsDb;

namespace TrafficSensors.Service.ReportsApi.Controllers
{
    [Route("/reports-api")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private IBusApi _busApi { get; set; }
        private SensorsDataDatabaseContext _sensorsDataDatabase { get; set; }
        private SensorDatabaseContext _sensorsRegistrationDatabase { get; set; }

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
        }

        /// <summary>
        /// Called periodically (about every 1 minute)
        /// </summary>
        public void ProcessJob()
        {
        }
    }
}

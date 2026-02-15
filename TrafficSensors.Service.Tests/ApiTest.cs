using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using TrafficSensors.Bus.Model;
using TrafficSensors.DB.SensorsDb;
using TrafficSensors.DB.DataDb;
using TrafficSensors.Bus.BusApi;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;

namespace TrafficSensors.Service.Tests
{
    public class ApiTest
    {
        private const string AppSettingsFile = "reportsapi.appsettings.json";
        private const string ServiceGuid = "24AE2694-00C7-4F78-898D-20617DA19DA2";

        [Test]
        public void SubscribeSensorRegistrationTest()
        {
            TestBusApi.Data.Clear();
            using (var factory = new CustomWebApplicationFactory<ReportsApi.Startup, SensorDatabaseContext, SensorsDataDatabaseContext>())
            using (var client = factory.CreateClient())
            {
                var serviceScopeFactory = (IServiceScopeFactory)factory.Services.GetService(typeof(IServiceScopeFactory));

                using (var scope = serviceScopeFactory.CreateScope())
                {
                    var services = scope.ServiceProvider;
                    var sensorsDB = services.GetRequiredService<SensorDatabaseContext>();
                    var sensorsDataDB = services.GetRequiredService<SensorsDataDatabaseContext>();
                    var busApi = services.GetRequiredService<IBusApi>();

                    Assert.IsFalse(TestBusApi.Data.Any(d => d.Key == SubscribeEventType.SensorRegistration && d.Value.Any(a => a.Key == ServiceGuid)));
                    
                    var integrationConfig = new ConfigurationBuilder().AddJsonFile(AppSettingsFile).Build();
                    var apiContoller = new ReportsApi.Controllers.ApiController(busApi, sensorsDataDB, sensorsDB, integrationConfig);
                    for(int i = 0; i < 5; i++)
                        apiContoller.ProcessJob(); // executed several times

                    Assert.IsTrue(TestBusApi.Data.Any(d => d.Key == SubscribeEventType.SensorRegistration && d.Value.Any(a => a.Key == ServiceGuid)));
                }
            }
        }

        [Test]
        public void ReadSensorDataTest()
        {
            TestBusApi.Data.Clear();
            using (var factory = new CustomWebApplicationFactory<ReportsApi.Startup, SensorDatabaseContext, SensorsDataDatabaseContext>())
            using (var client = factory.CreateClient())
            {
                var serviceScopeFactory = (IServiceScopeFactory)factory.Services.GetService(typeof(IServiceScopeFactory));

                using (var scope = serviceScopeFactory.CreateScope())
                {
                    var services = scope.ServiceProvider;
                    var sensorsDB = services.GetRequiredService<SensorDatabaseContext>();
                    var sensorsDataDB = services.GetRequiredService<SensorsDataDatabaseContext>();
                    var busApi = services.GetRequiredService<IBusApi>();

                    Assert.IsFalse(TestBusApi.Data.Any(d => d.Key == SubscribeEventType.SensorRegistration && d.Value.Any(a => a.Key == ServiceGuid)));

                    var integrationConfig = new ConfigurationBuilder().AddJsonFile(AppSettingsFile).Build();
                    var apiContoller = new ReportsApi.Controllers.ApiController(busApi, sensorsDataDB, sensorsDB, integrationConfig);
                    for (int i = 0; i < 5; i++)
                        apiContoller.ProcessJob(); // executed several times

                    Assert.IsTrue(TestBusApi.Data.Any(d => d.Key == SubscribeEventType.SensorRegistration && d.Value.Any(a => a.Key == ServiceGuid)));

                    Assert.AreEqual(0, sensorsDataDB.DetectedData.Count());

                    // send data
                    var otherServiceGuid = Guid.NewGuid().ToString();
                    var data = new SensorData() { DataGuid = Guid.NewGuid().ToString(), DetectionTime = DateTime.Now, NumberOfContacts = 2, SensorGuid = Guid.NewGuid().ToString() };
                    var data2 = new SensorData() { DataGuid = Guid.NewGuid().ToString(), DetectionTime = DateTime.Now, NumberOfContacts = 3, SensorGuid = Guid.NewGuid().ToString() };
                    busApi.Put(otherServiceGuid, data);
                    busApi.Put(otherServiceGuid, data2);

                    Assert.AreEqual(0, sensorsDataDB.DetectedData.Count());
                    apiContoller.ProcessJob();
                    var allFromDB = sensorsDataDB.DetectedData.ToList();
                    Assert.AreEqual(2, allFromDB.Count);
                    Assert.IsTrue(allFromDB.Any(a => a.DataGuid == data.DataGuid && a.DetectionTime == data.DetectionTime && a.NumberOfContacts == data.NumberOfContacts && a.SensorGuid == data.SensorGuid));
                    Assert.IsTrue(allFromDB.Any(a => a.DataGuid == data2.DataGuid && a.DetectionTime == data2.DetectionTime && a.NumberOfContacts == data2.NumberOfContacts && a.SensorGuid == data2.SensorGuid));
                }
            }
        }

        [Test]
        public void ReadSensorRegistrationDataTest()
        {
            TestBusApi.Data.Clear();
            using (var factory = new CustomWebApplicationFactory<ReportsApi.Startup, SensorDatabaseContext, SensorsDataDatabaseContext>())
            using (var client = factory.CreateClient())
            {
                var serviceScopeFactory = (IServiceScopeFactory)factory.Services.GetService(typeof(IServiceScopeFactory));

                using (var scope = serviceScopeFactory.CreateScope())
                {
                    var services = scope.ServiceProvider;
                    var sensorsDB = services.GetRequiredService<SensorDatabaseContext>();
                    var sensorsDataDB = services.GetRequiredService<SensorsDataDatabaseContext>();
                    var busApi = services.GetRequiredService<IBusApi>();

                    Assert.IsFalse(TestBusApi.Data.Any(d => d.Key == SubscribeEventType.SensorRegistration && d.Value.Any(a => a.Key == ServiceGuid)));

                    var integrationConfig = new ConfigurationBuilder().AddJsonFile(AppSettingsFile).Build();
                    var apiContoller = new ReportsApi.Controllers.ApiController(busApi, sensorsDataDB, sensorsDB, integrationConfig);
                    for (int i = 0; i < 5; i++)
                        apiContoller.ProcessJob(); // executed several times

                    Assert.IsTrue(TestBusApi.Data.Any(d => d.Key == SubscribeEventType.SensorRegistration && d.Value.Any(a => a.Key == ServiceGuid)));

                    Assert.AreEqual(0, sensorsDB.Sensors.Count());

                    // send data
                    var otherServiceGuid = Guid.NewGuid().ToString();
                    var data = new SensorRegistration() { GPSLocalization = "ABC", RegistrationTime = DateTime.Now, SensorGuid = Guid.NewGuid().ToString(), Specialization = Sensor.Type.SensorSpecialization.Car };
                    var data2 = new SensorRegistration() { GPSLocalization = "DEF", RegistrationTime = DateTime.Now, SensorGuid = Guid.NewGuid().ToString(), Specialization = Sensor.Type.SensorSpecialization.Motorbike };
                    busApi.Put(otherServiceGuid, data);
                    busApi.Put(otherServiceGuid, data2);

                    Assert.AreEqual(0, sensorsDB.Sensors.Count());
                    apiContoller.ProcessJob();
                    var allFromDB = sensorsDB.Sensors.ToList();
                    Assert.AreEqual(2, allFromDB.Count);
                    Assert.IsTrue(allFromDB.Any(a => a.GPSLocalization == data.GPSLocalization && a.RegistrationTime == data.RegistrationTime && a.SensorGuid == data.SensorGuid && a.SensorGuid == data.SensorGuid && a.SensorSpecialization == data.Specialization));
                    Assert.IsTrue(allFromDB.Any(a => a.GPSLocalization == data2.GPSLocalization && a.RegistrationTime == data2.RegistrationTime && a.SensorGuid == data2.SensorGuid && a.SensorGuid == data2.SensorGuid && a.SensorSpecialization == data2.Specialization));
                }
            }
        }
    }
}

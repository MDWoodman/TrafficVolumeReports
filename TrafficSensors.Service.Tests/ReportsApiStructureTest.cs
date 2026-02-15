
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using NUnit.Framework;

namespace TrafficSensors.Service.Tests
{
    /// <summary>
    /// !!! WARNING 
    /// !!! Project structure test.
    /// !!! DON'T CHANGE IT! 
    /// !!! Changes may cause the solution to be rejected.
    /// </summary>
    public class ReportsApiStructureTest
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// !!! WARNING 
        /// !!! Project structure test.
        /// !!! DON'T CHANGE IT! 
        /// !!! Changes may cause the solution to be rejected.
        /// </summary>
        [Test]
        public void StructureTest()
        {
            
            Assembly assembly;
            Type type;
            Type methodReturnType;
            MethodInfo method;
            int methodsCount;
            ParameterInfo parameter;
            int parametersCount;
            int constructorsCount;
            List<string> constructorParameterNameTypeDictionary;
            ConstructorInfo constructor;
            int fieldsCount;
            FieldInfo field;
            Type fieldReturnType;
            PropertyInfo property;
            int propertiesCount;
            Type propertyReturnType;
            assembly = Assembly.Load(Decode("VHJhZmZpY1NlbnNvcnMuU2VydmljZS5SZXBvcnRzQXBpLCBWZXJzaW9uPTEuMC4wLjAsIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49bnVsbA==") /*"TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"*/ );
            Assert.IsNotNull(assembly, "Missing  TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("UHJvZ3JhbQ==") /*"Program"*/ );
                Assert.IsNotNull(type, "Missing assembly: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Program");
                    Assert.IsTrue(type.IsClass, "assembly: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Program is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Program is not public class");
                            method = type.GetMethods().Where(m => !m.IsSpecialName && m.GetParameters().Length == 1).FirstOrDefault(x=>x.Name == Decode("TWFpbg==") /*"Main"*/ );                            Assert.IsNotNull(method, "method: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Program.Main(String[] args) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Program.Main(String[] args) is not public");
                            Assert.IsTrue(method.IsStatic, "method: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Program.Main(String[] args) is not static");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Void",methodReturnType.FullName, "method: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Program.Main(String[] args) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "method: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Program.Main(String[] args) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("YXJncw==") /*"args"*/  && x.ParameterType.FullName == "System.String[]");
                                Assert.IsNotNull(parameter, "method: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Program.Main(String[] args) parameter args does not exists or does not have type System.String[]");
                            method = type.GetMethods().Where(m => !m.IsSpecialName && m.GetParameters().Length == 1).FirstOrDefault(x=>x.Name == Decode("Q3JlYXRlSG9zdEJ1aWxkZXI=") /*"CreateHostBuilder"*/ );                            Assert.IsNotNull(method, "method: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Program.CreateHostBuilder(String[] args) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Program.CreateHostBuilder(String[] args) is not public");
                            Assert.IsTrue(method.IsStatic, "method: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Program.CreateHostBuilder(String[] args) is not static");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("Microsoft.Extensions.Hosting.IHostBuilder",methodReturnType.FullName, "method: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Program.CreateHostBuilder(String[] args) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "method: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Program.CreateHostBuilder(String[] args) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("YXJncw==") /*"args"*/  && x.ParameterType.FullName == "System.String[]");
                                Assert.IsNotNull(parameter, "method: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Program.CreateHostBuilder(String[] args) parameter args does not exists or does not have type System.String[]");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Program() does not exists");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("U3RhcnR1cA==") /*"Startup"*/ );
                Assert.IsNotNull(type, "Missing assembly: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Startup");
                    Assert.IsTrue(type.IsClass, "assembly: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Startup is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Startup is not public class");
                            method = type.GetMethods().Where(m => !m.IsSpecialName && m.GetParameters().Length == 1).FirstOrDefault(x=>x.Name == Decode("Q29uZmlndXJlU2VydmljZXM=") /*"ConfigureServices"*/ );                            Assert.IsNotNull(method, "method: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Startup.ConfigureServices(IServiceCollection services) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Startup.ConfigureServices(IServiceCollection services) is not public");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Void",methodReturnType.FullName, "method: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Startup.ConfigureServices(IServiceCollection services) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "method: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Startup.ConfigureServices(IServiceCollection services) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("c2VydmljZXM=") /*"services"*/  && x.ParameterType.FullName == "Microsoft.Extensions.DependencyInjection.IServiceCollection");
                                Assert.IsNotNull(parameter, "method: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Startup.ConfigureServices(IServiceCollection services) parameter services does not exists or does not have type Microsoft.Extensions.DependencyInjection.IServiceCollection");
                            method = type.GetMethods().Where(m => !m.IsSpecialName && m.GetParameters().Length == 2).FirstOrDefault(x=>x.Name == Decode("Q29uZmlndXJl") /*"Configure"*/ );                            Assert.IsNotNull(method, "method: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Startup.Configure(IApplicationBuilder appIWebHostEnvironment env) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Startup.Configure(IApplicationBuilder appIWebHostEnvironment env) is not public");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Void",methodReturnType.FullName, "method: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Startup.Configure(IApplicationBuilder appIWebHostEnvironment env) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(2,parametersCount, "method: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Startup.Configure(IApplicationBuilder appIWebHostEnvironment env) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("YXBw") /*"app"*/  && x.ParameterType.FullName == "Microsoft.AspNetCore.Builder.IApplicationBuilder");
                                Assert.IsNotNull(parameter, "method: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Startup.Configure(IApplicationBuilder appIWebHostEnvironment env) parameter app does not exists or does not have type Microsoft.AspNetCore.Builder.IApplicationBuilder");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(2,parametersCount, "method: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Startup.Configure(IApplicationBuilder appIWebHostEnvironment env) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("ZW52") /*"env"*/  && x.ParameterType.FullName == "Microsoft.AspNetCore.Hosting.IWebHostEnvironment");
                                Assert.IsNotNull(parameter, "method: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Startup.Configure(IApplicationBuilder appIWebHostEnvironment env) parameter env does not exists or does not have type Microsoft.AspNetCore.Hosting.IWebHostEnvironment");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructorParameterNameTypeDictionary.Add("Microsoft.Extensions.Configuration.IConfiguration");
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Startup(IConfiguration configuration) does not exists");
                                parametersCount = constructor.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "constructor: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Startup(IConfiguration configuration)  parameters count has changed");
                                parameter = constructor.GetParameters().FirstOrDefault(x=>x.Name == Decode("Y29uZmlndXJhdGlvbg==") /*"configuration"*/  && x.ParameterType.FullName == "Microsoft.Extensions.Configuration.IConfiguration");
                                Assert.IsNotNull(parameter, "constructor: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Startup(IConfiguration configuration) parameter configuration does not exists or does not have type Microsoft.Extensions.Configuration.IConfiguration");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("Q29uZmlndXJhdGlvbg==") /*"Configuration"*/ );
                            Assert.IsNotNull(property, "property: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Startup.IConfiguration Configuration does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0NvbmZpZ3VyYXRpb24=") /*"get_Configuration"*/ );                                Assert.IsNotNull(method, "method: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Startup.get_Configuration() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Startup.get_Configuration() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("Microsoft.Extensions.Configuration.IConfiguration",methodReturnType.FullName, "method: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Startup.get_Configuration() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("Microsoft.Extensions.Configuration.IConfiguration",propertyReturnType.FullName, "property: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Startup.IConfiguration Configuration  type has changed");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("QXBpQ29udHJvbGxlcg==") /*"ApiController"*/ );
                Assert.IsNotNull(type, "Missing assembly: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Controllers.ApiController");
                    Assert.IsTrue(type.IsClass, "assembly: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Controllers.ApiController is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Controllers.ApiController is not public class");
                            method = type.GetMethods().Where(m => !m.IsSpecialName && m.GetParameters().Length == 0).FirstOrDefault(x=>x.Name == Decode("UHJvY2Vzc0pvYg==") /*"ProcessJob"*/ );                            Assert.IsNotNull(method, "method: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Controllers.ApiController.ProcessJob() does not exists");
                            Assert.IsTrue(method.IsPublic, "method: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Controllers.ApiController.ProcessJob() is not public");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Void",methodReturnType.FullName, "method: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Controllers.ApiController.ProcessJob() return type has changed");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructorParameterNameTypeDictionary.Add("TrafficSensors.Bus.BusApi.IBusApi");
                            constructorParameterNameTypeDictionary.Add("TrafficSensors.DB.DataDb.SensorsDataDatabaseContext");
                            constructorParameterNameTypeDictionary.Add("TrafficSensors.DB.SensorsDb.SensorDatabaseContext");
                            constructorParameterNameTypeDictionary.Add("Microsoft.Extensions.Configuration.IConfiguration");
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Controllers.ApiController(IBusApi busApiSensorsDataDatabaseContext sensorsDataDbSensorDatabaseContext sensorsRegistrationDbIConfiguration configuration) does not exists");
                                parametersCount = constructor.GetParameters().Length;
                                Assert.AreEqual(4,parametersCount, "constructor: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Controllers.ApiController(IBusApi busApiSensorsDataDatabaseContext sensorsDataDbSensorDatabaseContext sensorsRegistrationDbIConfiguration configuration)  parameters count has changed");
                                parameter = constructor.GetParameters().FirstOrDefault(x=>x.Name == Decode("YnVzQXBp") /*"busApi"*/  && x.ParameterType.FullName == "TrafficSensors.Bus.BusApi.IBusApi");
                                Assert.IsNotNull(parameter, "constructor: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Controllers.ApiController(IBusApi busApiSensorsDataDatabaseContext sensorsDataDbSensorDatabaseContext sensorsRegistrationDbIConfiguration configuration) parameter busApi does not exists or does not have type TrafficSensors.Bus.BusApi.IBusApi");
                                parametersCount = constructor.GetParameters().Length;
                                Assert.AreEqual(4,parametersCount, "constructor: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Controllers.ApiController(IBusApi busApiSensorsDataDatabaseContext sensorsDataDbSensorDatabaseContext sensorsRegistrationDbIConfiguration configuration)  parameters count has changed");
                                parameter = constructor.GetParameters().FirstOrDefault(x=>x.Name == Decode("c2Vuc29yc0RhdGFEYg==") /*"sensorsDataDb"*/  && x.ParameterType.FullName == "TrafficSensors.DB.DataDb.SensorsDataDatabaseContext");
                                Assert.IsNotNull(parameter, "constructor: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Controllers.ApiController(IBusApi busApiSensorsDataDatabaseContext sensorsDataDbSensorDatabaseContext sensorsRegistrationDbIConfiguration configuration) parameter sensorsDataDb does not exists or does not have type TrafficSensors.DB.DataDb.SensorsDataDatabaseContext");
                                parametersCount = constructor.GetParameters().Length;
                                Assert.AreEqual(4,parametersCount, "constructor: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Controllers.ApiController(IBusApi busApiSensorsDataDatabaseContext sensorsDataDbSensorDatabaseContext sensorsRegistrationDbIConfiguration configuration)  parameters count has changed");
                                parameter = constructor.GetParameters().FirstOrDefault(x=>x.Name == Decode("c2Vuc29yc1JlZ2lzdHJhdGlvbkRi") /*"sensorsRegistrationDb"*/  && x.ParameterType.FullName == "TrafficSensors.DB.SensorsDb.SensorDatabaseContext");
                                Assert.IsNotNull(parameter, "constructor: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Controllers.ApiController(IBusApi busApiSensorsDataDatabaseContext sensorsDataDbSensorDatabaseContext sensorsRegistrationDbIConfiguration configuration) parameter sensorsRegistrationDb does not exists or does not have type TrafficSensors.DB.SensorsDb.SensorDatabaseContext");
                                parametersCount = constructor.GetParameters().Length;
                                Assert.AreEqual(4,parametersCount, "constructor: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Controllers.ApiController(IBusApi busApiSensorsDataDatabaseContext sensorsDataDbSensorDatabaseContext sensorsRegistrationDbIConfiguration configuration)  parameters count has changed");
                                parameter = constructor.GetParameters().FirstOrDefault(x=>x.Name == Decode("Y29uZmlndXJhdGlvbg==") /*"configuration"*/  && x.ParameterType.FullName == "Microsoft.Extensions.Configuration.IConfiguration");
                                Assert.IsNotNull(parameter, "constructor: TrafficSensors.Service.ReportsApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Service.ReportsApi.Controllers.ApiController(IBusApi busApiSensorsDataDatabaseContext sensorsDataDbSensorDatabaseContext sensorsRegistrationDbIConfiguration configuration) parameter configuration does not exists or does not have type Microsoft.Extensions.Configuration.IConfiguration");


        }

        /// <summary>
        /// !!! WARNING 
        /// !!! Project structure test.
        /// !!! DON'T CHANGE IT! 
        /// !!! Changes may cause the solution to be rejected.
        /// </summary>
        private string Decode(string text)
        {
            return System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(text));
        }
    }
}

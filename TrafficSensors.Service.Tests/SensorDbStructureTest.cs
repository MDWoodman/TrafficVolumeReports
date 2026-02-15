
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
    public class SensorDbStructureTest
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
            assembly = Assembly.Load(Decode("VHJhZmZpY1NlbnNvcnMuREIuU2Vuc29yc0RiLCBWZXJzaW9uPTEuMC4wLjAsIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49bnVsbA==") /*"TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"*/ );
            Assert.IsNotNull(assembly, "Missing  TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("U2Vuc29yRGF0YWJhc2VDb250ZXh0") /*"SensorDatabaseContext"*/ );
                Assert.IsNotNull(type, "Missing assembly: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.SensorDatabaseContext");
                    Assert.IsTrue(type.IsClass, "assembly: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.SensorDatabaseContext is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.SensorDatabaseContext is not public class");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructorParameterNameTypeDictionary.Add("Microsoft.EntityFrameworkCore.DbContextOptions`1[[TrafficSensors.DB.SensorsDb.SensorDatabaseContext, TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]");
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.SensorDatabaseContext(DbContextOptions`1 options) does not exists");
                                parametersCount = constructor.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "constructor: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.SensorDatabaseContext(DbContextOptions`1 options)  parameters count has changed");
                                parameter = constructor.GetParameters().FirstOrDefault(x=>x.Name == Decode("b3B0aW9ucw==") /*"options"*/  && x.ParameterType.IsGenericType && x.ParameterType.FullName.StartsWith("Microsoft.EntityFrameworkCore.DbContextOptions`1[[TrafficSensors.DB.SensorsDb.SensorDatabaseContext"));
                                Assert.IsNotNull(parameter, "constructor: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.SensorDatabaseContext(DbContextOptions`1 options) parameter options does not exists or does not have type Microsoft.EntityFrameworkCore.DbContextOptions`1[[TrafficSensors.DB.SensorsDb.SensorDatabaseContext, TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("U2Vuc29ycw==") /*"Sensors"*/ );
                            Assert.IsNotNull(property, "property: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.SensorDatabaseContext.DbSet`1 Sensors does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1NlbnNvcnM=") /*"get_Sensors"*/ );                                Assert.IsNotNull(method, "method: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.SensorDatabaseContext.get_Sensors() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.SensorDatabaseContext.get_Sensors() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("Microsoft.EntityFrameworkCore.DbSet`1[[TrafficSensors.DB.SensorsDb.Model.Sensor, TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]",methodReturnType.FullName, "method: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.SensorDatabaseContext.get_Sensors() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1NlbnNvcnM=") /*"get_Sensors"*/ );                                Assert.IsNotNull(method, "method: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.SensorDatabaseContext.get_Sensors() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.SensorDatabaseContext.get_Sensors() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("Microsoft.EntityFrameworkCore.DbSet`1[[TrafficSensors.DB.SensorsDb.Model.Sensor, TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]",methodReturnType.FullName, "method: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.SensorDatabaseContext.get_Sensors() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("Microsoft.EntityFrameworkCore.DbSet`1[[TrafficSensors.DB.SensorsDb.Model.Sensor, TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]",propertyReturnType.FullName, "property: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.SensorDatabaseContext.DbSet`1 Sensors  type has changed");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("U2Vuc29y") /*"Sensor"*/ );
                Assert.IsNotNull(type, "Missing assembly: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.Model.Sensor");
                    Assert.IsTrue(type.IsClass, "assembly: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.Model.Sensor is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.Model.Sensor is not public class");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.Model.Sensor() does not exists");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("SWQ=") /*"Id"*/ );
                            Assert.IsNotNull(property, "property: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.Model.Sensor.Int32 Id does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0lk") /*"get_Id"*/ );                                Assert.IsNotNull(method, "method: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.Model.Sensor.get_Id() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.Model.Sensor.get_Id() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.Int32",methodReturnType.FullName, "method: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.Model.Sensor.get_Id() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0lk") /*"get_Id"*/ );                                Assert.IsNotNull(method, "method: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.Model.Sensor.get_Id() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.Model.Sensor.get_Id() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.Int32",methodReturnType.FullName, "method: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.Model.Sensor.get_Id() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.Int32",propertyReturnType.FullName, "property: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.Model.Sensor.Int32 Id  type has changed");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("U2Vuc29yR3VpZA==") /*"SensorGuid"*/ );
                            Assert.IsNotNull(property, "property: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.Model.Sensor.String SensorGuid does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1NlbnNvckd1aWQ=") /*"get_SensorGuid"*/ );                                Assert.IsNotNull(method, "method: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.Model.Sensor.get_SensorGuid() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.Model.Sensor.get_SensorGuid() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.Model.Sensor.get_SensorGuid() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1NlbnNvckd1aWQ=") /*"get_SensorGuid"*/ );                                Assert.IsNotNull(method, "method: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.Model.Sensor.get_SensorGuid() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.Model.Sensor.get_SensorGuid() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.Model.Sensor.get_SensorGuid() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.String",propertyReturnType.FullName, "property: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.Model.Sensor.String SensorGuid  type has changed");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("R1BTTG9jYWxpemF0aW9u") /*"GPSLocalization"*/ );
                            Assert.IsNotNull(property, "property: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.Model.Sensor.String GPSLocalization does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0dQU0xvY2FsaXphdGlvbg==") /*"get_GPSLocalization"*/ );                                Assert.IsNotNull(method, "method: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.Model.Sensor.get_GPSLocalization() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.Model.Sensor.get_GPSLocalization() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.Model.Sensor.get_GPSLocalization() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0dQU0xvY2FsaXphdGlvbg==") /*"get_GPSLocalization"*/ );                                Assert.IsNotNull(method, "method: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.Model.Sensor.get_GPSLocalization() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.Model.Sensor.get_GPSLocalization() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.Model.Sensor.get_GPSLocalization() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.String",propertyReturnType.FullName, "property: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.Model.Sensor.String GPSLocalization  type has changed");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("U2Vuc29yU3BlY2lhbGl6YXRpb24=") /*"SensorSpecialization"*/ );
                            Assert.IsNotNull(property, "property: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.Model.Sensor.SensorSpecialization SensorSpecialization does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1NlbnNvclNwZWNpYWxpemF0aW9u") /*"get_SensorSpecialization"*/ );                                Assert.IsNotNull(method, "method: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.Model.Sensor.get_SensorSpecialization() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.Model.Sensor.get_SensorSpecialization() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("TrafficSensors.Sensor.Type.SensorSpecialization",methodReturnType.FullName, "method: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.Model.Sensor.get_SensorSpecialization() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1NlbnNvclNwZWNpYWxpemF0aW9u") /*"get_SensorSpecialization"*/ );                                Assert.IsNotNull(method, "method: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.Model.Sensor.get_SensorSpecialization() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.Model.Sensor.get_SensorSpecialization() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("TrafficSensors.Sensor.Type.SensorSpecialization",methodReturnType.FullName, "method: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.Model.Sensor.get_SensorSpecialization() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("TrafficSensors.Sensor.Type.SensorSpecialization",propertyReturnType.FullName, "property: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.Model.Sensor.SensorSpecialization SensorSpecialization  type has changed");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("UmVnaXN0cmF0aW9uVGltZQ==") /*"RegistrationTime"*/ );
                            Assert.IsNotNull(property, "property: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.Model.Sensor.DateTime RegistrationTime does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1JlZ2lzdHJhdGlvblRpbWU=") /*"get_RegistrationTime"*/ );                                Assert.IsNotNull(method, "method: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.Model.Sensor.get_RegistrationTime() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.Model.Sensor.get_RegistrationTime() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.DateTime",methodReturnType.FullName, "method: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.Model.Sensor.get_RegistrationTime() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1JlZ2lzdHJhdGlvblRpbWU=") /*"get_RegistrationTime"*/ );                                Assert.IsNotNull(method, "method: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.Model.Sensor.get_RegistrationTime() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.Model.Sensor.get_RegistrationTime() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.DateTime",methodReturnType.FullName, "method: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.Model.Sensor.get_RegistrationTime() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.DateTime",propertyReturnType.FullName, "property: TrafficSensors.DB.SensorsDb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.DB.SensorsDb.Model.Sensor.DateTime RegistrationTime  type has changed");


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

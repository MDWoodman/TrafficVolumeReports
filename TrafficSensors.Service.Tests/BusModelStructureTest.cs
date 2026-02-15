
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
    public class BusModelStructureTest
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
            assembly = Assembly.Load(Decode("VHJhZmZpY1NlbnNvcnMuQnVzLk1vZGVsLCBWZXJzaW9uPTEuMC4wLjAsIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49bnVsbA==") /*"TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"*/ );
            Assert.IsNotNull(assembly, "Missing  TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("QmFzZURhdGE=") /*"BaseData"*/ );
                Assert.IsNotNull(type, "Missing assembly: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.BaseData");
                    Assert.IsTrue(type.IsClass, "assembly: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.BaseData is not class");
                    Assert.IsTrue(type.IsAbstract, "assembly: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.BaseData is not abstract class");
                    Assert.IsTrue(type.IsPublic, "assembly: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.BaseData is not public class");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructorParameterNameTypeDictionary.Add("TrafficSensors.Bus.Model.SubscribeEventType");
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.BaseData(SubscribeEventType eventType) does not exists");
                                parametersCount = constructor.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "constructor: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.BaseData(SubscribeEventType eventType)  parameters count has changed");
                                parameter = constructor.GetParameters().FirstOrDefault(x=>x.Name == Decode("ZXZlbnRUeXBl") /*"eventType"*/  && x.ParameterType.FullName == "TrafficSensors.Bus.Model.SubscribeEventType");
                                Assert.IsNotNull(parameter, "constructor: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.BaseData(SubscribeEventType eventType) parameter eventType does not exists or does not have type TrafficSensors.Bus.Model.SubscribeEventType");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("RXZlbnRUeXBl") /*"EventType"*/ );
                            Assert.IsNotNull(property, "property: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.BaseData.SubscribeEventType EventType does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0V2ZW50VHlwZQ==") /*"get_EventType"*/ );                                Assert.IsNotNull(method, "method: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.BaseData.get_EventType() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.BaseData.get_EventType() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("TrafficSensors.Bus.Model.SubscribeEventType",methodReturnType.FullName, "method: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.BaseData.get_EventType() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0V2ZW50VHlwZQ==") /*"get_EventType"*/ );                                Assert.IsNotNull(method, "method: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.BaseData.get_EventType() does not exists");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("TrafficSensors.Bus.Model.SubscribeEventType",methodReturnType.FullName, "method: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.BaseData.get_EventType() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("TrafficSensors.Bus.Model.SubscribeEventType",propertyReturnType.FullName, "property: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.BaseData.SubscribeEventType EventType  type has changed");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("U2Vuc29yRGF0YQ==") /*"SensorData"*/ );
                Assert.IsNotNull(type, "Missing assembly: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorData");
                    Assert.IsTrue(type.IsClass, "assembly: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorData is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorData is not public class");
                    Assert.IsTrue(type.IsSealed, "assembly: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorData is not sealed type");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorData() does not exists");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("U2Vuc29yR3VpZA==") /*"SensorGuid"*/ );
                            Assert.IsNotNull(property, "property: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorData.String SensorGuid does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1NlbnNvckd1aWQ=") /*"get_SensorGuid"*/ );                                Assert.IsNotNull(method, "method: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorData.get_SensorGuid() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorData.get_SensorGuid() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorData.get_SensorGuid() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1NlbnNvckd1aWQ=") /*"get_SensorGuid"*/ );                                Assert.IsNotNull(method, "method: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorData.get_SensorGuid() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorData.get_SensorGuid() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorData.get_SensorGuid() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.String",propertyReturnType.FullName, "property: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorData.String SensorGuid  type has changed");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("RGF0YUd1aWQ=") /*"DataGuid"*/ );
                            Assert.IsNotNull(property, "property: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorData.String DataGuid does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0RhdGFHdWlk") /*"get_DataGuid"*/ );                                Assert.IsNotNull(method, "method: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorData.get_DataGuid() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorData.get_DataGuid() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorData.get_DataGuid() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0RhdGFHdWlk") /*"get_DataGuid"*/ );                                Assert.IsNotNull(method, "method: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorData.get_DataGuid() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorData.get_DataGuid() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorData.get_DataGuid() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.String",propertyReturnType.FullName, "property: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorData.String DataGuid  type has changed");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("RGV0ZWN0aW9uVGltZQ==") /*"DetectionTime"*/ );
                            Assert.IsNotNull(property, "property: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorData.DateTime DetectionTime does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0RldGVjdGlvblRpbWU=") /*"get_DetectionTime"*/ );                                Assert.IsNotNull(method, "method: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorData.get_DetectionTime() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorData.get_DetectionTime() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.DateTime",methodReturnType.FullName, "method: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorData.get_DetectionTime() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0RldGVjdGlvblRpbWU=") /*"get_DetectionTime"*/ );                                Assert.IsNotNull(method, "method: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorData.get_DetectionTime() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorData.get_DetectionTime() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.DateTime",methodReturnType.FullName, "method: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorData.get_DetectionTime() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.DateTime",propertyReturnType.FullName, "property: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorData.DateTime DetectionTime  type has changed");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("TnVtYmVyT2ZDb250YWN0cw==") /*"NumberOfContacts"*/ );
                            Assert.IsNotNull(property, "property: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorData.Int32 NumberOfContacts does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X051bWJlck9mQ29udGFjdHM=") /*"get_NumberOfContacts"*/ );                                Assert.IsNotNull(method, "method: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorData.get_NumberOfContacts() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorData.get_NumberOfContacts() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.Int32",methodReturnType.FullName, "method: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorData.get_NumberOfContacts() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X051bWJlck9mQ29udGFjdHM=") /*"get_NumberOfContacts"*/ );                                Assert.IsNotNull(method, "method: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorData.get_NumberOfContacts() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorData.get_NumberOfContacts() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.Int32",methodReturnType.FullName, "method: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorData.get_NumberOfContacts() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.Int32",propertyReturnType.FullName, "property: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorData.Int32 NumberOfContacts  type has changed");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("U2Vuc29yUmVnaXN0cmF0aW9u") /*"SensorRegistration"*/ );
                Assert.IsNotNull(type, "Missing assembly: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorRegistration");
                    Assert.IsTrue(type.IsClass, "assembly: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorRegistration is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorRegistration is not public class");
                    Assert.IsTrue(type.IsSealed, "assembly: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorRegistration is not sealed type");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorRegistration() does not exists");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("U2Vuc29yR3VpZA==") /*"SensorGuid"*/ );
                            Assert.IsNotNull(property, "property: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorRegistration.String SensorGuid does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1NlbnNvckd1aWQ=") /*"get_SensorGuid"*/ );                                Assert.IsNotNull(method, "method: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorRegistration.get_SensorGuid() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorRegistration.get_SensorGuid() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorRegistration.get_SensorGuid() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1NlbnNvckd1aWQ=") /*"get_SensorGuid"*/ );                                Assert.IsNotNull(method, "method: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorRegistration.get_SensorGuid() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorRegistration.get_SensorGuid() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorRegistration.get_SensorGuid() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.String",propertyReturnType.FullName, "property: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorRegistration.String SensorGuid  type has changed");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("U3BlY2lhbGl6YXRpb24=") /*"Specialization"*/ );
                            Assert.IsNotNull(property, "property: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorRegistration.SensorSpecialization Specialization does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1NwZWNpYWxpemF0aW9u") /*"get_Specialization"*/ );                                Assert.IsNotNull(method, "method: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorRegistration.get_Specialization() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorRegistration.get_Specialization() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("TrafficSensors.Sensor.Type.SensorSpecialization",methodReturnType.FullName, "method: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorRegistration.get_Specialization() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1NwZWNpYWxpemF0aW9u") /*"get_Specialization"*/ );                                Assert.IsNotNull(method, "method: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorRegistration.get_Specialization() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorRegistration.get_Specialization() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("TrafficSensors.Sensor.Type.SensorSpecialization",methodReturnType.FullName, "method: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorRegistration.get_Specialization() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("TrafficSensors.Sensor.Type.SensorSpecialization",propertyReturnType.FullName, "property: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorRegistration.SensorSpecialization Specialization  type has changed");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("R1BTTG9jYWxpemF0aW9u") /*"GPSLocalization"*/ );
                            Assert.IsNotNull(property, "property: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorRegistration.String GPSLocalization does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0dQU0xvY2FsaXphdGlvbg==") /*"get_GPSLocalization"*/ );                                Assert.IsNotNull(method, "method: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorRegistration.get_GPSLocalization() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorRegistration.get_GPSLocalization() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorRegistration.get_GPSLocalization() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0dQU0xvY2FsaXphdGlvbg==") /*"get_GPSLocalization"*/ );                                Assert.IsNotNull(method, "method: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorRegistration.get_GPSLocalization() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorRegistration.get_GPSLocalization() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorRegistration.get_GPSLocalization() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.String",propertyReturnType.FullName, "property: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorRegistration.String GPSLocalization  type has changed");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("UmVnaXN0cmF0aW9uVGltZQ==") /*"RegistrationTime"*/ );
                            Assert.IsNotNull(property, "property: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorRegistration.DateTime RegistrationTime does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1JlZ2lzdHJhdGlvblRpbWU=") /*"get_RegistrationTime"*/ );                                Assert.IsNotNull(method, "method: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorRegistration.get_RegistrationTime() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorRegistration.get_RegistrationTime() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.DateTime",methodReturnType.FullName, "method: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorRegistration.get_RegistrationTime() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1JlZ2lzdHJhdGlvblRpbWU=") /*"get_RegistrationTime"*/ );                                Assert.IsNotNull(method, "method: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorRegistration.get_RegistrationTime() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorRegistration.get_RegistrationTime() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.DateTime",methodReturnType.FullName, "method: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorRegistration.get_RegistrationTime() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.DateTime",propertyReturnType.FullName, "property: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SensorRegistration.DateTime RegistrationTime  type has changed");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("U3Vic2NyaWJlRXZlbnRUeXBl") /*"SubscribeEventType"*/ );
                Assert.IsNotNull(type, "Missing assembly: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SubscribeEventType");
                    Assert.IsTrue(type.IsEnum, "assembly: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SubscribeEventType is not enum type");
                    Assert.IsTrue(type.IsPublic, "assembly: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SubscribeEventType is not public class");
                    Assert.IsTrue(type.IsSealed, "assembly: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SubscribeEventType is not sealed type");
                    Assert.IsTrue(type.IsSerializable, "assembly: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SubscribeEventType is not serializable type");
                    Assert.IsTrue(type.IsValueType, "assembly: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SubscribeEventType is not value type");
                            field = type.GetFields().FirstOrDefault(x=>x.Name == Decode("U2Vuc29yUmVnaXN0cmF0aW9u") /*"SensorRegistration"*/ );
                            Assert.IsNotNull(field, "field: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SubscribeEventType.SubscribeEventType SensorRegistration does not exists");
                            Assert.IsTrue(field.IsPublic, "field: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SubscribeEventType.SubscribeEventType SensorRegistration is not public");
                            Assert.IsTrue(field.IsStatic, "field: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SubscribeEventType.SubscribeEventType SensorRegistration is not static");
                            fieldReturnType = field.FieldType;
                            Assert.AreEqual("TrafficSensors.Bus.Model.SubscribeEventType",fieldReturnType.FullName, "field: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SubscribeEventType.SubscribeEventType SensorRegistration  type has changed");
                            field = type.GetFields().FirstOrDefault(x=>x.Name == Decode("U2Vuc29yRGF0YQ==") /*"SensorData"*/ );
                            Assert.IsNotNull(field, "field: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SubscribeEventType.SubscribeEventType SensorData does not exists");
                            Assert.IsTrue(field.IsPublic, "field: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SubscribeEventType.SubscribeEventType SensorData is not public");
                            Assert.IsTrue(field.IsStatic, "field: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SubscribeEventType.SubscribeEventType SensorData is not static");
                            fieldReturnType = field.FieldType;
                            Assert.AreEqual("TrafficSensors.Bus.Model.SubscribeEventType",fieldReturnType.FullName, "field: TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.Model.SubscribeEventType.SubscribeEventType SensorData  type has changed");


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

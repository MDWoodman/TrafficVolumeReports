
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
    public class BusApiStructureTest
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
            assembly = Assembly.Load(Decode("VHJhZmZpY1NlbnNvcnMuQnVzLkJ1c0FwaSwgVmVyc2lvbj0xLjAuMC4wLCBDdWx0dXJlPW5ldXRyYWwsIFB1YmxpY0tleVRva2VuPW51bGw=") /*"TrafficSensors.Bus.BusApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"*/ );
            Assert.IsNotNull(assembly, "Missing  TrafficSensors.Bus.BusApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("SUJ1c0FwaQ==") /*"IBusApi"*/ );
                Assert.IsNotNull(type, "Missing assembly: TrafficSensors.Bus.BusApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.BusApi.IBusApi");
                    Assert.IsTrue(type.IsAbstract, "assembly: TrafficSensors.Bus.BusApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.BusApi.IBusApi is not abstract class");
                    Assert.IsTrue(type.IsInterface, "assembly: TrafficSensors.Bus.BusApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.BusApi.IBusApi is not interface");
                    Assert.IsTrue(type.IsPublic, "assembly: TrafficSensors.Bus.BusApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.BusApi.IBusApi is not public class");
                            method = type.GetMethods().Where(m => !m.IsSpecialName && m.GetParameters().Length == 2).FirstOrDefault(x=>x.Name == Decode("U3Vic2NyaWJl") /*"Subscribe"*/ );                            Assert.IsNotNull(method, "method: TrafficSensors.Bus.BusApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.BusApi.IBusApi.Subscribe(String serviceGuidSubscribeEventType type) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: TrafficSensors.Bus.BusApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.BusApi.IBusApi.Subscribe(String serviceGuidSubscribeEventType type) is not public");
                            Assert.IsTrue(method.IsAbstract, "method: TrafficSensors.Bus.BusApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.BusApi.IBusApi.Subscribe(String serviceGuidSubscribeEventType type) is not abstract");
                            Assert.IsTrue(method.IsVirtual, "method: TrafficSensors.Bus.BusApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.BusApi.IBusApi.Subscribe(String serviceGuidSubscribeEventType type) is not virtual");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Void",methodReturnType.FullName, "method: TrafficSensors.Bus.BusApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.BusApi.IBusApi.Subscribe(String serviceGuidSubscribeEventType type) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(2,parametersCount, "method: TrafficSensors.Bus.BusApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.BusApi.IBusApi.Subscribe(String serviceGuidSubscribeEventType type) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("c2VydmljZUd1aWQ=") /*"serviceGuid"*/  && x.ParameterType.FullName == "System.String");
                                Assert.IsNotNull(parameter, "method: TrafficSensors.Bus.BusApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.BusApi.IBusApi.Subscribe(String serviceGuidSubscribeEventType type) parameter serviceGuid does not exists or does not have type System.String");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(2,parametersCount, "method: TrafficSensors.Bus.BusApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.BusApi.IBusApi.Subscribe(String serviceGuidSubscribeEventType type) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("dHlwZQ==") /*"type"*/  && x.ParameterType.FullName == "TrafficSensors.Bus.Model.SubscribeEventType");
                                Assert.IsNotNull(parameter, "method: TrafficSensors.Bus.BusApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.BusApi.IBusApi.Subscribe(String serviceGuidSubscribeEventType type) parameter type does not exists or does not have type TrafficSensors.Bus.Model.SubscribeEventType");
                            method = type.GetMethods().Where(m => !m.IsSpecialName && m.GetParameters().Length == 2).FirstOrDefault(x=>x.Name == Decode("UHV0") /*"Put"*/ );                            Assert.IsNotNull(method, "method: TrafficSensors.Bus.BusApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.BusApi.IBusApi.Put(String serviceGuidBaseData data) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: TrafficSensors.Bus.BusApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.BusApi.IBusApi.Put(String serviceGuidBaseData data) is not public");
                            Assert.IsTrue(method.IsAbstract, "method: TrafficSensors.Bus.BusApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.BusApi.IBusApi.Put(String serviceGuidBaseData data) is not abstract");
                            Assert.IsTrue(method.IsVirtual, "method: TrafficSensors.Bus.BusApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.BusApi.IBusApi.Put(String serviceGuidBaseData data) is not virtual");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Void",methodReturnType.FullName, "method: TrafficSensors.Bus.BusApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.BusApi.IBusApi.Put(String serviceGuidBaseData data) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(2,parametersCount, "method: TrafficSensors.Bus.BusApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.BusApi.IBusApi.Put(String serviceGuidBaseData data) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("c2VydmljZUd1aWQ=") /*"serviceGuid"*/  && x.ParameterType.FullName == "System.String");
                                Assert.IsNotNull(parameter, "method: TrafficSensors.Bus.BusApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.BusApi.IBusApi.Put(String serviceGuidBaseData data) parameter serviceGuid does not exists or does not have type System.String");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(2,parametersCount, "method: TrafficSensors.Bus.BusApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.BusApi.IBusApi.Put(String serviceGuidBaseData data) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("ZGF0YQ==") /*"data"*/  && x.ParameterType.FullName == "TrafficSensors.Bus.Model.BaseData");
                                Assert.IsNotNull(parameter, "method: TrafficSensors.Bus.BusApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.BusApi.IBusApi.Put(String serviceGuidBaseData data) parameter data does not exists or does not have type TrafficSensors.Bus.Model.BaseData");
                            method = type.GetMethods().Where(m => !m.IsSpecialName && m.GetParameters().Length == 2).FirstOrDefault(x=>x.Name == Decode("UmVhZA==") /*"Read"*/ );                            Assert.IsNotNull(method, "method: TrafficSensors.Bus.BusApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.BusApi.IBusApi.Read(String serviceGuidSubscribeEventType type) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: TrafficSensors.Bus.BusApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.BusApi.IBusApi.Read(String serviceGuidSubscribeEventType type) is not public");
                            Assert.IsTrue(method.IsAbstract, "method: TrafficSensors.Bus.BusApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.BusApi.IBusApi.Read(String serviceGuidSubscribeEventType type) is not abstract");
                            Assert.IsTrue(method.IsVirtual, "method: TrafficSensors.Bus.BusApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.BusApi.IBusApi.Read(String serviceGuidSubscribeEventType type) is not virtual");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Collections.Generic.IList`1[[TrafficSensors.Bus.Model.BaseData, TrafficSensors.Bus.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]",methodReturnType.FullName, "method: TrafficSensors.Bus.BusApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.BusApi.IBusApi.Read(String serviceGuidSubscribeEventType type) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(2,parametersCount, "method: TrafficSensors.Bus.BusApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.BusApi.IBusApi.Read(String serviceGuidSubscribeEventType type) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("c2VydmljZUd1aWQ=") /*"serviceGuid"*/  && x.ParameterType.FullName == "System.String");
                                Assert.IsNotNull(parameter, "method: TrafficSensors.Bus.BusApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.BusApi.IBusApi.Read(String serviceGuidSubscribeEventType type) parameter serviceGuid does not exists or does not have type System.String");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(2,parametersCount, "method: TrafficSensors.Bus.BusApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.BusApi.IBusApi.Read(String serviceGuidSubscribeEventType type) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("dHlwZQ==") /*"type"*/  && x.ParameterType.FullName == "TrafficSensors.Bus.Model.SubscribeEventType");
                                Assert.IsNotNull(parameter, "method: TrafficSensors.Bus.BusApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Bus.BusApi.IBusApi.Read(String serviceGuidSubscribeEventType type) parameter type does not exists or does not have type TrafficSensors.Bus.Model.SubscribeEventType");


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

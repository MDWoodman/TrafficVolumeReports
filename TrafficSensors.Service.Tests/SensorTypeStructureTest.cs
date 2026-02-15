
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
    public class SensorTypeStructureTest
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
            assembly = Assembly.Load(Decode("VHJhZmZpY1NlbnNvcnMuU2Vuc29yLlR5cGUsIFZlcnNpb249MS4wLjAuMCwgQ3VsdHVyZT1uZXV0cmFsLCBQdWJsaWNLZXlUb2tlbj1udWxs") /*"TrafficSensors.Sensor.Type, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"*/ );
            Assert.IsNotNull(assembly, "Missing  TrafficSensors.Sensor.Type, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("U2Vuc29yU3BlY2lhbGl6YXRpb24=") /*"SensorSpecialization"*/ );
                Assert.IsNotNull(type, "Missing assembly: TrafficSensors.Sensor.Type, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Sensor.Type.SensorSpecialization");
                    Assert.IsTrue(type.IsEnum, "assembly: TrafficSensors.Sensor.Type, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Sensor.Type.SensorSpecialization is not enum type");
                    Assert.IsTrue(type.IsPublic, "assembly: TrafficSensors.Sensor.Type, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Sensor.Type.SensorSpecialization is not public class");
                    Assert.IsTrue(type.IsSealed, "assembly: TrafficSensors.Sensor.Type, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Sensor.Type.SensorSpecialization is not sealed type");
                    Assert.IsTrue(type.IsSerializable, "assembly: TrafficSensors.Sensor.Type, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Sensor.Type.SensorSpecialization is not serializable type");
                    Assert.IsTrue(type.IsValueType, "assembly: TrafficSensors.Sensor.Type, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Sensor.Type.SensorSpecialization is not value type");
                            field = type.GetFields().FirstOrDefault(x=>x.Name == Decode("Q2Fy") /*"Car"*/ );
                            Assert.IsNotNull(field, "field: TrafficSensors.Sensor.Type, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Sensor.Type.SensorSpecialization.SensorSpecialization Car does not exists");
                            Assert.IsTrue(field.IsPublic, "field: TrafficSensors.Sensor.Type, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Sensor.Type.SensorSpecialization.SensorSpecialization Car is not public");
                            Assert.IsTrue(field.IsStatic, "field: TrafficSensors.Sensor.Type, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Sensor.Type.SensorSpecialization.SensorSpecialization Car is not static");
                            fieldReturnType = field.FieldType;
                            Assert.AreEqual("TrafficSensors.Sensor.Type.SensorSpecialization",fieldReturnType.FullName, "field: TrafficSensors.Sensor.Type, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Sensor.Type.SensorSpecialization.SensorSpecialization Car  type has changed");
                            field = type.GetFields().FirstOrDefault(x=>x.Name == Decode("QmlrZQ==") /*"Bike"*/ );
                            Assert.IsNotNull(field, "field: TrafficSensors.Sensor.Type, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Sensor.Type.SensorSpecialization.SensorSpecialization Bike does not exists");
                            Assert.IsTrue(field.IsPublic, "field: TrafficSensors.Sensor.Type, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Sensor.Type.SensorSpecialization.SensorSpecialization Bike is not public");
                            Assert.IsTrue(field.IsStatic, "field: TrafficSensors.Sensor.Type, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Sensor.Type.SensorSpecialization.SensorSpecialization Bike is not static");
                            fieldReturnType = field.FieldType;
                            Assert.AreEqual("TrafficSensors.Sensor.Type.SensorSpecialization",fieldReturnType.FullName, "field: TrafficSensors.Sensor.Type, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Sensor.Type.SensorSpecialization.SensorSpecialization Bike  type has changed");
                            field = type.GetFields().FirstOrDefault(x=>x.Name == Decode("UGVyc29u") /*"Person"*/ );
                            Assert.IsNotNull(field, "field: TrafficSensors.Sensor.Type, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Sensor.Type.SensorSpecialization.SensorSpecialization Person does not exists");
                            Assert.IsTrue(field.IsPublic, "field: TrafficSensors.Sensor.Type, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Sensor.Type.SensorSpecialization.SensorSpecialization Person is not public");
                            Assert.IsTrue(field.IsStatic, "field: TrafficSensors.Sensor.Type, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Sensor.Type.SensorSpecialization.SensorSpecialization Person is not static");
                            fieldReturnType = field.FieldType;
                            Assert.AreEqual("TrafficSensors.Sensor.Type.SensorSpecialization",fieldReturnType.FullName, "field: TrafficSensors.Sensor.Type, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Sensor.Type.SensorSpecialization.SensorSpecialization Person  type has changed");
                            field = type.GetFields().FirstOrDefault(x=>x.Name == Decode("TW90b3JiaWtl") /*"Motorbike"*/ );
                            Assert.IsNotNull(field, "field: TrafficSensors.Sensor.Type, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Sensor.Type.SensorSpecialization.SensorSpecialization Motorbike does not exists");
                            Assert.IsTrue(field.IsPublic, "field: TrafficSensors.Sensor.Type, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Sensor.Type.SensorSpecialization.SensorSpecialization Motorbike is not public");
                            Assert.IsTrue(field.IsStatic, "field: TrafficSensors.Sensor.Type, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Sensor.Type.SensorSpecialization.SensorSpecialization Motorbike is not static");
                            fieldReturnType = field.FieldType;
                            Assert.AreEqual("TrafficSensors.Sensor.Type.SensorSpecialization",fieldReturnType.FullName, "field: TrafficSensors.Sensor.Type, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Sensor.Type.SensorSpecialization.SensorSpecialization Motorbike  type has changed");
                            field = type.GetFields().FirstOrDefault(x=>x.Name == Decode("T3RoZXI=") /*"Other"*/ );
                            Assert.IsNotNull(field, "field: TrafficSensors.Sensor.Type, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Sensor.Type.SensorSpecialization.SensorSpecialization Other does not exists");
                            Assert.IsTrue(field.IsPublic, "field: TrafficSensors.Sensor.Type, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Sensor.Type.SensorSpecialization.SensorSpecialization Other is not public");
                            Assert.IsTrue(field.IsStatic, "field: TrafficSensors.Sensor.Type, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Sensor.Type.SensorSpecialization.SensorSpecialization Other is not static");
                            fieldReturnType = field.FieldType;
                            Assert.AreEqual("TrafficSensors.Sensor.Type.SensorSpecialization",fieldReturnType.FullName, "field: TrafficSensors.Sensor.Type, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TrafficSensors.Sensor.Type.SensorSpecialization.SensorSpecialization Other  type has changed");


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

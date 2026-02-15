using System;
using System.Collections.Generic;
using System.Text;
using TrafficSensors.Sensor.Type;

namespace TrafficSensors.Bus.Model
{
    /// <summary>
    /// Informations about registered sensor.
    /// </summary>
    public sealed class SensorRegistration : BaseData
    {
        public SensorRegistration() : base(SubscribeEventType.SensorRegistration)
        {
        }

        /// <summary>
        /// Unique sensor identifier (GUID)
        /// </summary>
        public String SensorGuid { get; set; }

        /// <summary>
        /// Sensor specialization.
        /// </summary>
        public SensorSpecialization Specialization { get; set; }

        /// <summary>
        /// GPS localization.
        /// </summary>
        public string GPSLocalization { get; set; }

        /// <summary>
        /// Registration time.
        /// </summary>
        public DateTime RegistrationTime { get; set; }
    }
}

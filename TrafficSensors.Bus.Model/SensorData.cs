using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficSensors.Bus.Model
{
    /// <summary>
    /// Informations about data recorded by sensor.
    /// </summary>
    public sealed class SensorData : BaseData
    {
        public SensorData(): base(SubscribeEventType.SensorData)
        {
        }

        /// <summary>
        /// Unique sensor identifier (GUID)
        /// </summary>
        public string SensorGuid { get; set; }

        /// <summary>
        /// A unique identifier (GUID) that identifies the recorded data
        /// </summary>
        public string DataGuid { get; set; }

        /// <summary>
        /// Time of record data by sensor.
        /// </summary>
        public DateTime DetectionTime { get; set; }

        /// <summary>
        /// Number of contacts recognized by sensor.
        /// </summary>
        public int NumberOfContacts { get; set; }
    }
}

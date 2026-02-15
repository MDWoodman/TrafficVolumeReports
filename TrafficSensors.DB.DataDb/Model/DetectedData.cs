using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrafficSensors.DB.DataDb.Model
{
    public class DetectedData
    {
        /// <summary>
        /// Unique Id
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int Id { get; set; }

        /// <summary>
        /// A unique identifier (GUID) that identifies the recorded data
        /// </summary>
        public string DataGuid { get; set; }

        /// <summary>
        /// Unique sensor identifier (GUID)
        /// </summary>
        public string SensorGuid { get; set; }

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

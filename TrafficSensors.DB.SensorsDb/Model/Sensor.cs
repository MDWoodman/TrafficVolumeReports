using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TrafficSensors.Sensor.Type;

namespace TrafficSensors.DB.SensorsDb.Model
{
    public class Sensor
    {
        /// <summary>
        /// Unique Id
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int Id { get; set; }

        /// <summary>
        /// Unique sensor identifier (GUID)
        /// </summary>
        public string SensorGuid { get; set; }

        /// <summary>
        /// GPS localization.
        /// </summary>
        public string GPSLocalization { get; set; }

        /// <summary>
        /// Sensor specialization.
        /// </summary>
        public SensorSpecialization SensorSpecialization { get; set; }

        /// <summary>
        /// Registration time.
        /// </summary>
        public DateTime RegistrationTime { get; set; }
    }
}

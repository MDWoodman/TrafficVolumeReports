using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficSensors.Sensor.Type
{
    /// <summary>
    /// Sensor specialization.
    /// </summary>
    public enum SensorSpecialization : int
    {
        /// <summary>
        /// Sensor recognizes cars.
        /// </summary>
        Car = 0,
        /// <summary>
        /// Sensor recognizes bikes.
        /// </summary>
        Bike = 1,
        /// <summary>
        /// Sensor recognizes persons.
        /// </summary>
        Person = 2,
        /// <summary>
        /// Sensor recognizes motorbikes.
        /// </summary>
        Motorbike = 3,
        /// <summary>
        /// Sensor recognizes others objects not specified above.
        /// </summary>
        Other = 99,
    }
}

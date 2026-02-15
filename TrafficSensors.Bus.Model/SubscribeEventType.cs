using System;

namespace TrafficSensors.Bus.Model
{
    public enum SubscribeEventType : int
    {
        /// <summary>
        /// Subscription of information about sensor registration
        /// </summary>
        SensorRegistration = 1,

        /// <summary>
        /// Subscription of information about sensor data
        /// </summary>
        SensorData = 2,
    }
}

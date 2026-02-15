using System;
using System.Collections.Generic;
using TrafficSensors.Bus.Model;

namespace TrafficSensors.Bus.BusApi
{
    /// <summary>
    /// Data Bus API.
    /// </summary>
    public interface IBusApi
    {
        /// <summary>
        /// Subscribe events in data bus.
        /// </summary>
        /// <param name="serviceGuid">Unique service identifier (GUID) that want subscribe the data.</param>
        /// <param name="type"></param>
        void Subscribe(string serviceGuid, SubscribeEventType type);

        /// <summary>
        /// Sends message by data bus to all subscribers.
        /// </summary>
        /// <param name="serviceGuid">Unique service identifier (GUID) that send the data.</param>
        /// <param name="data">Data ready to send to subscribers.</param>
        void Put(string serviceGuid, BaseData data);

        /// <summary>
        /// Reads all subsribed data. If there is no data function returns empty list or null. 
        /// </summary>
        /// <param name="serviceGuid">Unique service identifier (GUID) that want to read data.</param>
        /// <returns>Subscribed data.</returns>
        IList<BaseData> Read(string serviceGuid, SubscribeEventType type);
    }
}

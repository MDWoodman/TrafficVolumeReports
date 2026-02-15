using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrafficSensors.Bus.BusApi;
using TrafficSensors.Bus.Model;

namespace TrafficSensors.Service.Tests
{
    public class TestBusApi : IBusApi
    {
        public static IDictionary<SubscribeEventType, IDictionary<string, IList<BaseData>>> Data = new Dictionary<SubscribeEventType, IDictionary<string, IList<BaseData>>>();

        public void Put(string serviceGuid, BaseData data)
        {
            if (data != null)
            {
                // are subscriptions so add to all
                if (Data.ContainsKey(data.EventType))
                    foreach (var subscriber in Data[data.EventType])
                        subscriber.Value.Add(data);
            }
        }

        public IList<BaseData> Read(string serviceGuid, SubscribeEventType type)
        {
            if (Data.ContainsKey(type))
                if (Data[type].ContainsKey(serviceGuid))
                {
                    var res = Data[type][serviceGuid].ToList();
                    Data[type][serviceGuid].Clear();
                    return res;
                }
            return null;
        }

        public void Subscribe(string serviceGuid, SubscribeEventType type)
        {
            if (!Data.ContainsKey(type))
                Data.Add(type, new Dictionary<string, IList<BaseData>>());

            if (!Data[type].ContainsKey(serviceGuid))
                Data[type].Add(serviceGuid, new List<BaseData>());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficSensors.Bus.Model
{
    public abstract class BaseData
    {
        public BaseData(SubscribeEventType eventType)
        {
            EventType = eventType;
        }
        
        public SubscribeEventType EventType { get; private set; }
    }
}

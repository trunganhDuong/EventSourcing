using System;
using System.Collections.Generic;
using System.Text;

namespace EventSourcing.Enums
{
    public static class EventTypes
    {
        public enum ShippingEventTypes
        {
            Arrival =1,
            Departure=2
        }
    }
}

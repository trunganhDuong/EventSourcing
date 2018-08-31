using System;
using System.Collections.Generic;
using System.Text;
using EventSourcing.DomainEvents;
using EventSourcing.Enums;
using EventSourcing.Models;

namespace EventSourcing.Factories
{
    public static class ShippingEventFactory
    {
        public static DomainEvent Create(EventTypes.ShippingEventTypes type, DateTime occured, Ship ship, Port location, Port prev)
        {
            switch (type)
            {
                case EventTypes.ShippingEventTypes.Arrival:
                    return new ArrivalEvent(occured, ship, location, prev);
                case EventTypes.ShippingEventTypes.Departure:
                    return new DepartureEvent(occured, ship, location, prev);
                default:
                    return new ArrivalEvent(occured, ship, location, prev);
            }
        }
    }
}

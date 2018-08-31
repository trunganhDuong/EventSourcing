using System;
using System.Collections.Generic;
using System.Text;
using EventSourcing.Models;

namespace EventSourcing.DomainEvents
{
    public abstract class ShippingEvent : DomainEvent
    {
        public Ship Ship { get; private set; }

        public Port Location { get; private set; }

        public Port PreviousLocation { get; private set; }

        protected ShippingEvent(DateTime occured, Ship ship, Port port, Port prev) : base(occured)
        {
            this.Ship = ship;
            this.Location = port;
            this.PreviousLocation = prev;
        }
    }
}

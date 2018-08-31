using System;
using System.Collections.Generic;
using System.Text;
using EventSourcing.Models;

namespace EventSourcing.DomainEvents
{
    public class DepartureEvent:ShippingEvent
    {
        public DepartureEvent(DateTime occured, Ship ship, Port port, Port prev) : base(occured, ship, port, prev)
        {
        }

        internal override void Process()
        {
            this.Ship.Location = this.Location;
            Console.WriteLine($"Ship {Ship.ShipName} has departure from Port {PreviousLocation.PortName} to Port {Location.PortName}");
        }

        internal override void Revert()
        {
            this.Ship.Location = this.PreviousLocation;
            Console.WriteLine("Departure Event reverted");
        }
    }
}

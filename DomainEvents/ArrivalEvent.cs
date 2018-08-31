using System;
using System.Collections.Generic;
using System.Text;
using EventSourcing.Models;

namespace EventSourcing.DomainEvents
{
    public class ArrivalEvent: ShippingEvent
    {
        public ArrivalEvent(DateTime occured, Ship ship, Port port, Port prev) : base(occured, ship, port, prev)
        {
        }

        internal override void Process()
        {
            this.Ship.Location = this.Location;
            Console.WriteLine($"Ship {Ship.ShipName} has arrived to Port {Location.PortName} from Port {PreviousLocation.PortName}");
        }

        internal override void Revert()
        {
            this.Ship.Location = this.PreviousLocation;
            Console.WriteLine("Event reversed");
        }
    }
}

using System;
using System.Collections.Generic;
using EventSourcing.Enums;
using EventSourcing.Factories;
using EventSourcing.Models;

namespace EventSourcing
{
    class Program
    {
        static void Main(string[] args)
        {
            var eventHandler = new DomainEvents.EventHandler();
            List<Ship> ships = Data.Data.GetListShip();
            List<Port> ports = Data.Data.GetListPort();

            for (int i = 0; i < ships.Count; i++)
            {
                ships[i].Location = ports[i];
            }

            var departureEvent = ShippingEventFactory.Create(EventTypes.ShippingEventTypes.Departure,DateTime.Now, ships[0],
                ports[1], ships[0].Location);

            Console.WriteLine(ships[0]);
            eventHandler.Process(departureEvent);
            Console.WriteLine(ships[0]);
            eventHandler.Revert(departureEvent);
            Console.WriteLine(ships[0]);

            Console.ReadKey();
        }
    }
}

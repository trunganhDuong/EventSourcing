using System;
using System.Collections.Generic;
using System.Text;

namespace EventSourcing.Models
{
    public class Ship
    {
        public int ShipId { get; set; }

        public string ShipName { get; set; }

        public Port Location { get; set; }

        public Ship(int id, string name, Port location = null)
        {
            ShipId = id;
            ShipName = name;
            Location = location;
        }

        public override string ToString()
        {
            return $"Name: {ShipName} \nLocation: {Location.ToString()}";
        }
    }
}

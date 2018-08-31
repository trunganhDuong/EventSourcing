using System;
using System.Collections.Generic;
using System.Text;

namespace EventSourcing.Models
{
    public class Port
    {
        public int PortId { get; set; }
        public string PortName { get; set; }

        public Port(int id, string name)
        {
            PortId = id;
            PortName = name;
        }

        public override string ToString()
        {
            return $"{PortName}";
        }
    }
}

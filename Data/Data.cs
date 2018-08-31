using System;
using System.Collections.Generic;
using System.Text;
using EventSourcing.Models;

namespace EventSourcing.Data
{
    public static class Data
    {
        public static List<Ship> GetListShip()
        {
            return new List<Ship>
            {
                new Ship(1,"Titanic"),
                new Ship(2,"Roger II"),
                new Ship(3,"The Queen"),
                new Ship(4,"Wave")
            };
        }

        public static List<Port> GetListPort()
        {
            return new List<Port>
            {
                new Port(1,"Hai Phong"),
                new Port(2,"New York"),
                new Port(3,"ShangHai"),
                new Port(4,"Canada")
            };
        }
    }
}

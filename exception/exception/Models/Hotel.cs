using System;
using System.Collections.Generic;
using System.Text;

namespace exception.Models
{
    class Hotel
    {
        public string Name;
        private Room[] _Rooms;

        public Hotel(string Name)
        {
            this.Name = Name;
        }
        public void AddRoom(Room[] x)
        {
             _Rooms = x;
        }

    }
}

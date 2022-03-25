using System;
using System.Collections.Generic;
using System.Text;

namespace exception.Models
{
    class Room
    {
        private static int _id;
        public string Name;
        public double Price;
        public int PersonCapacity;
        public bool IsAvailable;
        public static int _Id { get; }


        public Room(string Name,double Price,int PersonCapacity, bool IsAvailable=true)
        {
            this.Name = Name;
            this.Price = Price;
            this.PersonCapacity = PersonCapacity;
            this.IsAvailable = IsAvailable;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}\nPrice: {Price}\nPersonCapacity: {PersonCapacity}\nReservation: {IsAvailable}");
        }
    }
}

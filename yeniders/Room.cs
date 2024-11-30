using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace yeniders
{
    public class Room
    {
        private static int _idcounter = 0;
        public int Id {get;}
        public string Name {get; set;}
        public double Price {get; set;}
        public int PersonCapacity {get; set;}
        public bool IsAvaible {get; set;}
        public Room(string name, double price, int personCapacity)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Ad bosh ola bolmez");
            }
            if (price <= 0)
            {
                throw new ArgumentException("Price 0-dan boyuk olmalidir.");
            }
            if (personCapacity <= 0)
            {
                throw new ArgumentException("Person Capaciti 0-dan boyuk olmalidir.");
            }
            Id = ++ _idcounter;
            Name = name;
            Price = price;
            PersonCapacity = personCapacity;
        }
        public void ShowInfo()
        {
            System.Console.WriteLine($"Room ID: {Id}\nName: {Name}\nPrice: {Price}\nPerson Capacity: {PersonCapacity}\nIs Available: {IsAvaible}");
        }
        public override string ToString()
        {
            return $"Romm Info:\n{ShowInfo}";
        }
    }
}
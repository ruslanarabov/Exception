using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace yeniders
{
    public class Hotel
    {
        public string Name {get; set;}
        private List<Room> Rooms {get; set;} = new List<Room>();
        public Hotel (string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Hotel adi bos ola bilmez.");
            }
            Name = name;
        }
        public void AddRoom(Room room)
        {
            if (room == null)
            {
                throw new ArgumentNullException("room", "Room null ola bilmez.");
            }
            Rooms.Add(room);
        }
        public void MakeResevation(int? roomId)
        {
            if (roomId == null)
            {
                throw new NullReferenceException("room ID null olammaz");
            }
            Room foundRoom = null;
            foreach (var room in Rooms)
            {
                if (room.Id == roomId)
                {
                    foundRoom = room;
                    break;
                }
            }
            if (foundRoom == null)
            {
                throw new ArgumentException($"Verilen {roomId}'de otaq yoxdur");
            }
            if (!foundRoom.IsAvaible)
            {
                throw new ArgumentException("Reserv uvun otaq yoxdur.");
            }
            foundRoom.IsAvaible = false;
            System.Console.WriteLine($"Room ID: {roomId} ugurla rezerv olundu.");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projet.Models
{
    public class Room
    {
        public int Id { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
        public int RoomNumber { get; set; }
        public int Price { get; set; }
        public int Capacity { get; set; }
        public bool IsAvailable { get; set; }
    }

}

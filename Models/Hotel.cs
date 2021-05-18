using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication4.Models;
using Microsoft.EntityFrameworkCore;
namespace WebApplication4.Models
{
    public class Hotel
    {

        public int Id { get; set; }
        public int RoomNumber { get; set; }
        public int RoomPrice { get; set; }
        public CityHotel CityHotels { get; set; }
       
        public int CituHotelId { get; set; }
        public ICollection<Customer> Customers { get; set; }
    }
}
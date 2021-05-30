using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication4.Models;
using Microsoft.EntityFrameworkCore;
namespace WebApplication4
{
    public class HotelsViewModel
    {

        
        public int RoomNumber { get; set; }
        public int RoomPrice { get; set; }
        public int CituHotelId { get; set; }
        public string CityName { get; set; }
    }
}

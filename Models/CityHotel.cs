using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication4.Models;
using Microsoft.EntityFrameworkCore;
namespace WebApplication4.Models
{
    public class CityHotel
    {
        public int Id { get; set; }
        public string CityName { get; set; }

        public ICollection<Hotel> Hotels { get; set; }


    }
}
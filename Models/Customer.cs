using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication4.Models;
using Microsoft.EntityFrameworkCore;
namespace WebApplication4.Models
{
    public class Customer
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotels { get; set; }
    }
}
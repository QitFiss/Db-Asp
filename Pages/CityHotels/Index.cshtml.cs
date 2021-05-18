using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;

namespace WebApplication4.Pages.CityHotels
{
    public class IndexModel : PageModel
    {
        private readonly WebApplication4.Models.HotelData _context;

        public IndexModel(WebApplication4.Models.HotelData context)
        {
            _context = context;
        }

        public IList<CityHotel> CityHotel { get;set; }

        public async Task OnGetAsync()
        {
            CityHotel = await _context.CityHotels.ToListAsync();
        }
    }
}

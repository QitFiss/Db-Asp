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
    public class DeleteModel : PageModel
    {
        private readonly WebApplication4.Models.HotelData _context;

        public DeleteModel(WebApplication4.Models.HotelData context)
        {
            _context = context;
        }

        [BindProperty]
        public CityHotel CityHotel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CityHotel = await _context.CityHotels.FirstOrDefaultAsync(m => m.Id == id);

            if (CityHotel == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CityHotel = await _context.CityHotels.FindAsync(id);

            if (CityHotel != null)
            {
                _context.CityHotels.Remove(CityHotel);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

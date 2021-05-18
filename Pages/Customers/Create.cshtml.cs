using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication4.Models;

namespace WebApplication4.Pages.Customers
{
    public class CreateModel : PageModel
    {
        private readonly WebApplication4.Models.HotelData _context;

        public CreateModel(WebApplication4.Models.HotelData context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["HotelId"] = new SelectList(_context.Hotels, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Customer Customer { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Customers.Add(Customer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

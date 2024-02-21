using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TestIdentity2.Data;
using TestIdentity2.Models;

namespace TestIdentity2.Pages.ManageFood
{
    public class DetailsModel : PageModel
    {
        private readonly TestIdentity2.Data.ApplicationDbContext _context;

        public DetailsModel(TestIdentity2.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Food Food { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var food = await _context.foods.FirstOrDefaultAsync(m => m.Id == id);
            if (food == null)
            {
                return NotFound();
            }
            else
            {
                Food = food;
            }
            return Page();
        }
    }
}

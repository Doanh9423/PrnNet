using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TestIdentity2.Data;
using TestIdentity2.Models;

namespace TestIdentity2.Pages.Manage
{
    public class DetailsModel : PageModel
    {
        private readonly TestIdentity2.Data.ApplicationDbContext _context;

        public DetailsModel(TestIdentity2.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Article Article { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = await _context.articles.FirstOrDefaultAsync(m => m.Id == id);
            if (article == null)
            {
                return NotFound();
            }
            else
            {
                Article = article;
            }
            return Page();
        }
    }
}

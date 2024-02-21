using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TestIdentity2.Data;
using TestIdentity2.Models;

namespace TestIdentity2.Pages.ManageFood
{
    [Authorize(Roles ="admin")]
    public class IndexModel : PageModel
    {
        private readonly TestIdentity2.Data.ApplicationDbContext _context;

        public IndexModel(TestIdentity2.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Food> Food { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Food = await _context.foods.ToListAsync();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorMoviesVincentA55.Data;
using RazorMoviesVincentA55.Models;

namespace RazorMoviesVincentA55.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly RazorMoviesVincentA55.Data.ApplicationDbContext _context;

        public DetailsModel(RazorMoviesVincentA55.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

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
    public class IndexModel : PageModel
    {
        private readonly RazorMoviesVincentA55.Data.ApplicationDbContext _context;

        public IndexModel(RazorMoviesVincentA55.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}

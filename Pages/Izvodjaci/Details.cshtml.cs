using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FrogMusicFest.Data;
using FrogMusicFest.Models;

namespace FrogMusicFest
{
    public class DetailsModel : PageModel
    {
        private readonly FrogMusicFest.Data.FrogMusicFestContext _context;

        public DetailsModel(FrogMusicFest.Data.FrogMusicFestContext context)
        {
            _context = context;
        }

        public Izvodjac Izvodjac { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Izvodjac = await _context.Izvodjac.FirstOrDefaultAsync(m => m.Id == id);

            if (Izvodjac == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

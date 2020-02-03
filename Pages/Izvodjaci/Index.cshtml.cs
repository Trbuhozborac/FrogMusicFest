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
    public class IndexModel : PageModel
    {
        private readonly FrogMusicFest.Data.FrogMusicFestContext _context;

        public IndexModel(FrogMusicFest.Data.FrogMusicFestContext context)
        {
            _context = context;
        }

        public IList<Izvodjac> Izvodjac { get;set; }

        public async Task OnGetAsync()
        {
            Izvodjac = await _context.Izvodjac.ToListAsync();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FrogMusicFest.Data;
using FrogMusicFest.Models;

namespace FrogMusicFest
{
    public class CreateModel : PageModel
    {
        private readonly FrogMusicFest.Data.FrogMusicFestContext _context;

        public CreateModel(FrogMusicFest.Data.FrogMusicFestContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Izvodjac Izvodjac { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Izvodjac.Add(Izvodjac);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

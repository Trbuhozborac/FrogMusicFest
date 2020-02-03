using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FrogMusicFest.Data;
using FrogMusicFest.Models;

namespace FrogMusicFest
{
    public class EditModel : PageModel
    {
        private readonly FrogMusicFest.Data.FrogMusicFestContext _context;

        public EditModel(FrogMusicFest.Data.FrogMusicFestContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Izvodjac).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IzvodjacExists(Izvodjac.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool IzvodjacExists(int id)
        {
            return _context.Izvodjac.Any(e => e.Id == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectBuild01.Model;
using ProjectBuild01.Models;

namespace ProjectBuild01.Pages.StaffPage
{
    public class EditModel : PageModel
    {
        private readonly ProjectBuild01.Models.ProjectBuild01Context _context;

        public EditModel(ProjectBuild01.Models.ProjectBuild01Context context)
        {
            _context = context;
        }

        [BindProperty]
        public StaffDb StaffDb { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            StaffDb = await _context.StaffDb.FirstOrDefaultAsync(m => m.ID == id);

            if (StaffDb == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(StaffDb).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StaffDbExists(StaffDb.ID))
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

        private bool StaffDbExists(int id)
        {
            return _context.StaffDb.Any(e => e.ID == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjectBuild01.Model;
using ProjectBuild01.Models;

namespace ProjectBuild01.Pages.StaffPage
{
    public class DeleteModel : PageModel
    {
        private readonly ProjectBuild01.Models.ProjectBuild01Context _context;

        public DeleteModel(ProjectBuild01.Models.ProjectBuild01Context context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            StaffDb = await _context.StaffDb.FindAsync(id);

            if (StaffDb != null)
            {
                _context.StaffDb.Remove(StaffDb);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

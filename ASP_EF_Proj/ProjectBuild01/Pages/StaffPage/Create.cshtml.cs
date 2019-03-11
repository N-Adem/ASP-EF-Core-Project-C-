using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjectBuild01.Model;
using ProjectBuild01.Models;

namespace ProjectBuild01.Pages.StaffPage
{
    public class CreateModel : PageModel
    {
        private readonly ProjectBuild01.Models.ProjectBuild01Context _context;

        public CreateModel(ProjectBuild01.Models.ProjectBuild01Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public StaffDb StaffDb { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.StaffDb.Add(StaffDb);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
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
    public class IndexModel : PageModel
    {
        private readonly ProjectBuild01.Models.ProjectBuild01Context _context;

        public IndexModel(ProjectBuild01.Models.ProjectBuild01Context context)
        {
            _context = context;
        }

        public IList<StaffDb> StaffDb { get;set; }

        public async Task OnGetAsync()
        {
            StaffDb = await _context.StaffDb.ToListAsync();
        }
    }
}

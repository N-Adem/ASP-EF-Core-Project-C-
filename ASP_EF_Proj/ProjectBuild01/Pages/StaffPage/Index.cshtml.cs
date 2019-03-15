using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjectBuild01.Model;

namespace ProjectBuild01.Pages.StaffPage
{
    public class IndexModel : PageModel
    {
        public IList<StaffDb> StaffDb { get; set; }
        public IList<PaySheetDb> PayDb { get; set; }
        private readonly ProjectBuild01.Models.ProjectBuild01Context _context;
        IndexModel() { }
        public IndexModel(ProjectBuild01.Models.ProjectBuild01Context context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            StaffDb = await _context.StaffDb.ToListAsync();
            PayDb = await _context.PaySheetDb.ToListAsync();
        }
    }
}

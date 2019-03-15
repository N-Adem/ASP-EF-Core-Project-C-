using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectBuild01.Model;
namespace ProjectBuild01.Pages.StaffPage
{
    public class TotalPayModel : PageModel
    {
        List<PaySheetDb> payeSheet = new List<PaySheetDb>();
        public void Initialize()
        {
            //using (var db = new contextt)
        }
        public void OnGet()
        {

        }
    }
}
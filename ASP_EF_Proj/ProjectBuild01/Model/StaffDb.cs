using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBuild01.Model
{
    public class StaffDb
    {
        public int ID { get; set; }
        public string staffName { get; set; }
        public int payID { get; set; }
        public double monthlyTotal { get; set; }

        public ICollection<PaySheetDb> payTotal { get; set;}

       
    }
}

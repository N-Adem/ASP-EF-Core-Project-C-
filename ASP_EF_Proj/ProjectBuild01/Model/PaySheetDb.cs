using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBuild01.Model
{
    public class PaySheetDb
    {
        public int payID {get; set; }
        public float week1Hours { get; set; }
        public float week2Hours { get; set; }
        public float week3Hours { get; set; }
        public float week4Hours { get; set; }
        public double monthlyTotal { get; set; }

    }
}

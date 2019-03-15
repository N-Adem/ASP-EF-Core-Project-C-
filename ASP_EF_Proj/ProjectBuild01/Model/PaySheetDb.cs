using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace ProjectBuild01.Model
{
    public class PaySheetDb
    {
        private int totalHours;
        public int ID { get; set; }
        public int HourlyPay { get; set; }
        public int Week1Hours { get; set; }
        public int Week2Hours { get; set; }
        public int Week3Hours { get; set; }
        public int Week4Hours { get; set; }
        public int TotalHours { get { return totalHours; }
            set {
                totalHours = (Week1Hours + Week2Hours + Week3Hours
                    + Week4Hours) * HourlyPay;
            } }
        
        public PaySheetDb() { } 
        
    }
}

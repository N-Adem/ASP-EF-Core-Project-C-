using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectBuild01.Model;

namespace ProjectBuild01.Models
{
    public class ProjectBuild01Context : DbContext
    {
        public ProjectBuild01Context (DbContextOptions<ProjectBuild01Context> options)
            : base(options)
        {
        }

        public DbSet<ProjectBuild01.Model.StaffDb> StaffDb { get; set; }
        public DbSet<ProjectBuild01.Model.PaySheetDb> PaySheetDb { get; set; }
    }
}

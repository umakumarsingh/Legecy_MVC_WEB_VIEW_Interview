using InterviewTracker.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interviewtracker.DataLayer
{
    public class InterviewerTrackerDbContext : DbContext
    {
        public InterviewerTrackerDbContext()
            : base("name=InterviewerTrackerDbContext")
        {
        }
        public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public virtual DbSet<Interview> Interviews { get; set; }
    }
}

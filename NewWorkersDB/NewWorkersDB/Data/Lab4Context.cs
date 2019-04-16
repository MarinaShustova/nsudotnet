using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NewWorkersDB.Models;

namespace NewWorkersDB.Models
{
    public class Lab4Context : DbContext
    {
        public Lab4Context (DbContextOptions<Lab4Context> options)
            : base(options)
        {
        }

        public DbSet<NewWorkersDB.Models.Worker> Worker { get; set; }

        public DbSet<NewWorkersDB.Models.Project> Project { get; set; }
    }
}

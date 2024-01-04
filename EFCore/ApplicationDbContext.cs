using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore
{
    internal class ApplicationDbContext : DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlServer(@"Data Source=(localdb)\ProjectModels;Initial Catalog=EFECore;Integrated Security=True");
        public DbSet<Eemployeee> Employees { get; set; }
    }
}

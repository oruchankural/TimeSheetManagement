using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheetManagement.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer("Data Source = LENOVO; Initial Catalog = TimeSheetManagement;Trusted_Connection=True;");
        }
     
        public DbSet<User> Users { get; set; }
    
    }
}

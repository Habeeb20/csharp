using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PaelystSolution.Models;
namespace c__software.Data
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Employee> Employee{ get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=localhost;user=root;database=node_project";
            
            var serverVersion = new MySqlServerVersion(new Version(10, 4, 28));
            optionsBuilder.UseMySql(connectionString, serverVersion);
        }
    }
}
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sign_in.BackEnd
{
    public class Educational_DB : DbContext
    {
        public DbSet<St_Models> St_InfM { get; set; }
        public DbSet<Tch_Models> Tch_InfM { get; set; }
        public DbSet<Mg_Models> Mg_InfM { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Education;Trusted_Connection=True;");
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_LMS_.BackEnd
{
    public class DB_Proj : DbContext
    {
        public DbSet<St_Models> St_InfM { get; set; }
        public DbSet<Tch_Models> Tch_InfM { get; set; }
        public DbSet<Mg_Models> Mg_InfM { get; set; }
        public DbSet<MajorsLessons> Lessons { get; set; }
        public DbSet<Marks.AllMarks> Marks { get; set; }
        public DbSet<Marks.MemM> MemD { get; set; }
        public DbSet<Marks.MechM> MechD { get; set; }
        public DbSet<Marks.ShimiM> ShimiD { get; set; }
        public DbSet<Marks.CompM> CompD { get; set; }
        public DbSet<Marks.OmranM> OmranD { get; set; }
        public DbSet<Marks.BarqM> BarqD { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=NewDB;Trusted_Connection=True;");
        }
    }
}

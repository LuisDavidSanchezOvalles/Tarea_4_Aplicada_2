using Microsoft.EntityFrameworkCore;
using SavingData.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SavingData.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Estudiante> Estudiantes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS; Database=SchoolDB; Trusted_Connection=True;");
        }
    }
}

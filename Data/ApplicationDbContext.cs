using Microsoft.EntityFrameworkCore;
using StudentCrud.Models;
using System.Collections.Generic;

namespace StudentCrud.Data
{
    public class StudentDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=db5019.public.databaseasp.net; Database=db5019; User Id=db5019; Password=X?o68aP!=L5i; Encrypt=False; MultipleActiveResultSets=True;");
        }
    }
}

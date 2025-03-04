using Clean.Core.Entities;
using Clean.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Clean.Data
{
    public class DataContext : DbContext, IDataContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=sample_db");
            optionsBuilder.LogTo(builder => Debug.WriteLine(builder));
        }

        //public DataContext()
        //{
        //        Users = new List<User>() { 
        //        new User() { Id = 1, Email="user@dd.com", Name ="user", Password="1234"}
        //        };
        //}
    }
}

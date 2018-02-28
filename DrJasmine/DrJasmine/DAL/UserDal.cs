using DrJasmine.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DrJasmine.DAL
{
    public class UserDal:DbContext
    {
        public DbSet<User> user { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("tblUsers");
            //base.OnModelCreating(modelBuilder);
        }
    }
}
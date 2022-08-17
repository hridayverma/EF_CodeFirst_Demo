using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EF_CodeFirst_Demo.Models
{
    public partial class PGDACContext : DbContext
    {
        public PGDACContext()
            : base("name=PGDACContext")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        //define DbSet properties for each Entity Model
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Address> Address { get; set; }

    }
}

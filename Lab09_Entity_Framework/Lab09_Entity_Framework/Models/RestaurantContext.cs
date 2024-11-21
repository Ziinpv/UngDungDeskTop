using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Entity_Framework.Models
{
    public class RestaurantContext : DbContext
    {
        public DbSet<Category> Category { get; set; }

        public DbSet<Food> Food { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Food>()
                   .HasRequired(x => x.Category)
                   .WithMany()
                   .HasForeignKey(x => x.FoodCategoryID)
                   .WillCascadeOnDelete(true);
        }
    }
}

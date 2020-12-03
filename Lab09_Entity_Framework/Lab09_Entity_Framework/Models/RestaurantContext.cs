using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Entity_Framework.Models
{
    public class RestaurantContext : DbContext
    {
        public DbSet<Category>categories{ get; set; }
        public DbSet<Food> foods { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Food>()
                .HasRequired(x => x.category)
                .WithMany()
                .HasForeignKey(x => x.FoodCategoryID)
                .WillCascadeOnDelete(true);
        }
    }
}

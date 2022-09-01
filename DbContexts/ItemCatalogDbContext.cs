using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShoppingSmart.Services.ItemsCatalog.Entities;

namespace ShoppingSmart.Services.ItemsCatalog.DbContexts
{
    public class ItemCatalogDbContext : DbContext
    {
        public ItemCatalogDbContext(DbContextOptions<ItemCatalogDbContext> options) : base(options)
        {
            
        }
        public DbSet<SmartItem> SmartItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var smartItem1Guid = Guid.Parse("{CFB88E29-4744-48C0-94FA-B25B92DEA314}");
            var smartItem2Guid = Guid.Parse("{CFB88E29-4744-48C0-94FA-B25B92DEA315}");
            var smartItem3Guid = Guid.Parse("{CFB88E29-4744-48C0-94FA-B25B92DEA316}");
            var smartItem4Guid = Guid.Parse("{CFB88E29-4744-48C0-94FA-B25B92DEA317}");


            modelBuilder.Entity<SmartItem>().HasData(
                new SmartItem
                {
                    Id = smartItem1Guid,
                    BrandName = "Heinz",
                    Description = "Original Ketchup",
                    Name = "Ketchup",
                    Price = 3.47m
                });
            modelBuilder.Entity<SmartItem>().HasData(
                new SmartItem
                {
                    Id = smartItem2Guid,
                    BrandName = "Hunts",
                    Description = "Original Ketchup",
                    Name = "Cat-sup",
                    Price = 3.03m
                });
            modelBuilder.Entity<SmartItem>().HasData(
                new SmartItem
                {
                    Id = smartItem3Guid,
                    BrandName = "Goya",
                    Description = "Original Ketchup",
                    Name = "Ketchup",
                    Price = 3.87m
                });
            modelBuilder.Entity<SmartItem>().HasData(
                new SmartItem
                {
                    Id = smartItem4Guid,
                    BrandName = "Hellman",
                    Description = "Original Ketchup",
                    Name = "Ketchup",
                    Price = 3.57m
                });
        }
    }

}

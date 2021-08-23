using BlueSport.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSport.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BannerConfig());
            modelBuilder.ApplyConfiguration(new BannerTypeConfig());
            modelBuilder.ApplyConfiguration(new BrandConfig());
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new ColorConfig());
            modelBuilder.ApplyConfiguration(new ContactConfig());
            modelBuilder.ApplyConfiguration(new OrderConfig());
            modelBuilder.ApplyConfiguration(new OrderDetailConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());
            modelBuilder.ApplyConfiguration(new ProductDetailConfig());
            modelBuilder.ApplyConfiguration(new ProductImageConfig());
            modelBuilder.ApplyConfiguration(new ProductMapCateConfig());
            modelBuilder.ApplyConfiguration(new ProductMapSizeConfig());
            modelBuilder.ApplyConfiguration(new PromotionConfig());
            modelBuilder.ApplyConfiguration(new PromotionDetailConfig());
            modelBuilder.ApplyConfiguration(new SizeConfig());
            modelBuilder.ApplyConfiguration(new SizeMapColorConfig());
            modelBuilder.ApplyConfiguration(new TopicConfig());
            //base.OnModelCreating(modelBuilder);
        }

        public DbSet<Banner> Banners { get; set; }
        public DbSet<BannerType> BannerTypes { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductMapCate> ProductMapCates { get; set; }
        public DbSet<ProductMapSize> ProductMapSizes { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<PromotionDetail> PromotionDetails { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<SizeMapColor> SizeMapColors { get; set; }
        public DbSet<Topic> Topics { get; set; }
    }
}

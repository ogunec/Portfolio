using Microsoft.EntityFrameworkCore;
using Portfolio.MODEL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.DAL.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //Kullandığımız veritabanı ile ilgili configurasyonları yaptığımız metot
        {
            optionsBuilder.UseSqlServer("server=.;database=PortfolioDB;uid=sa;pwd=12345");
        }

        //Bunlar bizim Entity sınıflarımıza veritabanında karşılık gelecek tabloları oluşturduğumuz kod bloğu.
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<MyPortfolio> MyPortfolios { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
    }
}

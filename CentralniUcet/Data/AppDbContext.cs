#define EFUPDATEx

using CentralniUcet.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CentralniUcet.Data
{
    public partial class AppDbContext
        : DbContext
    {
        public DbSet<UcetCentralni> UcetCentralni { get; set; }
        public DbSet<UcetJidelny> UcetJidelny { get; set; }
        public DbSet<OverovaciMail> OverovaciMail { get; set; }
        public DbSet<Autentifikace> Autentifikace { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
          : base(options)
        {
        }


        //        public DbSet<DummyModel> DummyModel { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            base.OnConfiguring(options);
            options.UseLoggerFactory(LoggerFactory.Create(builder => builder.AddDebug()));
            //#if EFUPDATE
            //            options.UseSqlServer("Server=(local)\\sqlexpressvis;Database=InfoPanel;Trusted_Connection=True;MultipleActiveResultSets=true");
            //#else
            //options.UseSqlServer(_configuration.GetConnectionString("InfoPanel"));
            //#endif
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<UcetCentralni>()
                .HasKey(r => r.Veta);
            builder.Entity<UcetCentralni>(uc =>
                uc.HasIndex(x => x.IDUcetCentralni).IsUnique());
            builder.Entity<UcetCentralni>(uc =>
                uc.HasIndex(x => x.Email).IsUnique());

            builder.Entity<UcetJidelny>()
                .HasKey(r => r.Veta);
            builder.Entity<UcetJidelny>().HasOne(x => x.UcetCentralni).WithMany(y => y.UcetJidelnyList)
                .HasForeignKey(y=>y.IDUcetCentralni).OnDelete(DeleteBehavior.Cascade);

            builder.Entity<OverovaciMail>()
                .HasKey(r => r.Veta);
            builder.Entity<OverovaciMail>().HasOne(x => x.UcetCentralni).WithMany(y => y.OverovaciMailList)
                .HasForeignKey(y => y.IDUcetCentralni).OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Autentifikace>()
               .HasKey(r => r.Veta);
            builder.Entity<Autentifikace>(uc =>
               uc.HasIndex(x => x.Uzivatel).IsUnique());
        }
    }

}


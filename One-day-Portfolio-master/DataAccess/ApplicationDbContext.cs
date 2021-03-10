using Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Sect1> Sect1s { get; set; }
        public DbSet<Sect2> Sect2s { get; set; }
        public DbSet<Sect3> Sect3s { get; set; }
        public DbSet<Sect4> Sect4s { get; set; }
        public DbSet<Sect5> Sect5s { get; set; }
        public DbSet<Sect6> Sect6s { get; set; }
        public DbSet<Sect7> Sect7s { get; set; }

    }
}

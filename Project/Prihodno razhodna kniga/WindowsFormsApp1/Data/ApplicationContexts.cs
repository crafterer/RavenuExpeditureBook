﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Data.Models;

namespace WindowsFormsApp1.Data
{
    public class ApplicationContexts : DbContext
    {
        public ApplicationContexts()
        {

        }


        public ApplicationContexts(DbContextOptions options)
            :base(options)
        {

        }
        
        public virtual DbSet<PersonLoginContexts> PersonRegisters { get; set; }

        public virtual DbSet<PersonAccountContexts> PersonAccounts { get; set; }

        public virtual DbSet<RevenueExpenditureBookContexts> RevenueExpenditureBooks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer
                    (Configuration.ConnectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
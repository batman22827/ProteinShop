﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProteinShop
{
    public class UserDataContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = db.db");
        }


        public DbSet <User>? Users { get; set; }
        public DbSet <Drink> Drinks { get; set; }
        public DbSet<Cart> Carts { get; set; }




    }
}

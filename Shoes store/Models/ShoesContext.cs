﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Shoes_store.Models
{
    public class ShoesContext:DbContext
    {
        public DbSet<Shoes> Shoes { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
    }
}
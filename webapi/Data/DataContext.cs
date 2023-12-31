﻿using Microsoft.EntityFrameworkCore;
using webapi.Entities;

namespace webapi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Recipe> Recipe { get; set; }

    }
}

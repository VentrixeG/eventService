﻿using Microsoft.EntityFrameworkCore;
using Persistence.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Contexts
{
    public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
    {
        public DbSet<EventEntity> Events { get; set; }
        public DbSet<PackageEntity> Packages { get; set; }
        public DbSet<EventPackageEntity> EventPackages { get; set; }
    }
}

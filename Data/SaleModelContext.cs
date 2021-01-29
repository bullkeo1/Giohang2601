using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Giohang2601.Models;

    public class SaleModelContext : DbContext
    {
        public SaleModelContext (DbContextOptions<SaleModelContext> options)
            : base(options)
        {
        }

        public DbSet<Giohang2601.Models.Product> Product { get; set; }
    }

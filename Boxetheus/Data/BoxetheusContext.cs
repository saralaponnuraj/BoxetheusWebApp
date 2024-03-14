using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Boxetheus.Models;

namespace Boxetheus.Data
{
    public class BoxetheusContext : DbContext
    {
        public BoxetheusContext (DbContextOptions<BoxetheusContext> options)
            : base(options)
        {
        }

        public DbSet<Boxetheus.Models.BoxView> BoxView { get; set; } = default!;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SaleWebMvc.Models;

namespace SaleWebMvc.Data
{
    public class SaleWebMvcContext : DbContext
    {
        public SaleWebMvcContext (DbContextOptions<SaleWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<SaleWebMvc.Models.Departments> Departments { get; set; } = default!;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Week_3_Lab.Models;

namespace Week_3_Lab.Data
{
    public class Week_3_LabContext : DbContext
    {
        public Week_3_LabContext(DbContextOptions<Week_3_LabContext> options)
            : base(options)
        {
        }

        public DbSet<Week_3_Lab.Models.Products> Products { get; set; } = default!;
    }
}
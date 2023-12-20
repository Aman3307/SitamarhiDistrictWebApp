using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DQSP.Models;

using Microsoft.EntityFrameworkCore;

namespace DQSP.Data
{
    public class DistrictQueryModelDBContext : DbContext
    {
        public DistrictQueryModelDBContext(DbContextOptions<DistrictQueryModelDBContext> options)
            : base(options)
        {
        }
        public DbSet<DistrictQueryModel> DistrictQueries { get; set; }
    }
}

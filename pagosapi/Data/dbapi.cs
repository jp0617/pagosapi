using Microsoft.EntityFrameworkCore;
using pagosapi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pagosapi.Data
{
    public class dbapi:DbContext
    {
        public dbapi(DbContextOptions<dbapi> options):base(options)
        {

        }

        public DbSet<pago> pago { get; set; }
        public DbSet<logistica> logistica { get; set; }
    }
}

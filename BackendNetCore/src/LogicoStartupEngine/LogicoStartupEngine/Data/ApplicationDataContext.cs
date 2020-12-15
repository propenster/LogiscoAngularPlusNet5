using LogicoStartupEngine.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogicoStartupEngine.Data
{
    public class ApplicationDataContext : DbContext
    {

        public ApplicationDataContext(DbContextOptions<ApplicationDataContext> options) : base(options)
        {

        }

        public DbSet<LogisticCompany> LogisticCompanies { get; set; }

    }
}

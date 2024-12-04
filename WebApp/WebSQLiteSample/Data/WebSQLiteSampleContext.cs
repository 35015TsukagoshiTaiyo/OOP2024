using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebSQLiteSample.Models;

namespace WebSQLiteSample.Data
{
    public class WebSQLiteSampleContext : DbContext
    {
        public WebSQLiteSampleContext (DbContextOptions<WebSQLiteSampleContext> options)
            : base(options)
        {
        }

        public DbSet<WebSQLiteSample.Models.JobData> JobData { get; set; } = default!;
    }
}

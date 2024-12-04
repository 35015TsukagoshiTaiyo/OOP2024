using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebSampleApp.Models;

namespace WebSampleApp.Data
{
    public class WebSampleAppContext : DbContext
    {
        public WebSampleAppContext (DbContextOptions<WebSampleAppContext> options)
            : base(options)
        {
        }

        public DbSet<WebSampleApp.Models.JobData> JobData { get; set; } = default!;
    }
}

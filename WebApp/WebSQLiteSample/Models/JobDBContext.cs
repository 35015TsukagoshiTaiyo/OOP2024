using Microsoft.EntityFrameworkCore;

namespace WebSQLiteSample.Models {
    public class JobDBContext :DbContext{
        public JobDBContext(DbContextOptions options) : base(options) { }

        public DbSet<JobData>? JobData { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        //    optionsBuilder.UseSqlite("Data Source=job.db");
        //}
    }
}

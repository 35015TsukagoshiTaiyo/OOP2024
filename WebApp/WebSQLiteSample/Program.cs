using WebSQLiteSample.Models; // WebSQLiteSample
using Microsoft.EntityFrameworkCore; // EF Core 
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebSQLiteSample.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<WebSQLiteSampleContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("WebSQLiteSampleContext") ?? throw new InvalidOperationException("Connection string 'WebSQLiteSampleContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

// �f�[�^�x�[�X�̐ݒ� (SQLite �̏ꍇ)
builder.Services.AddDbContext<JobDBContext>(options =>
    options.UseSqlite("Data Source=job.db")); // jobdata.db 

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()) {
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

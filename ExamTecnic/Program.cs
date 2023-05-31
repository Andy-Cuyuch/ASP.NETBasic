using ExamTecnic.Models;
using Microsoft.EntityFrameworkCore;

/*
 Scaffold-DbContext "Server=LAPTOP-MG5UB2V3\SQLEXPRESS; Database=DBTECNICO; 
 Trusted_Connection=True; TrustServerCertificate=True;" 
 Microsoft.EntityFrameworkCore.SqlServer -OutPutDir Models
*/



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DbtecnicoContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("baseUrl"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

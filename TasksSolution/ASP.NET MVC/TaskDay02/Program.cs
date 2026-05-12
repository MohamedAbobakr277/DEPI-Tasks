using EFCoreTask.Data;
using EFCoreTask.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>();

var app = builder.Build();

// Ensure Database is Created and Seed Sample Data
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    context.Database.EnsureCreated();

    if (!context.Departments.Any())
    {
        var dept1 = new Department { Name = "Computer Science", MgrName = "Dr. Smith" };
        var dept2 = new Department { Name = "Information Technology", MgrName = "Dr. Jones" };

        context.Departments.AddRange(dept1, dept2);

        context.Students.AddRange(
            new Student { Name = "Alice Johnson", Age = 20, Department = dept1 },
            new Student { Name = "Bob Smith", Age = 22, Department = dept1 },
            new Student { Name = "Charlie Brown", Age = 21, Department = dept2 },
            new Student { Name = "Diana Prince", Age = 23, Department = dept2 }
        );

        context.SaveChanges();
    }
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

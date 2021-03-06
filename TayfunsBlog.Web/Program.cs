using Microsoft.EntityFrameworkCore;
using TayfunsBlog.Core.Repositories;
using TayfunsBlog.Core.Services;
using TayfunsBlog.Core.UnitOfWorks;
using TayfunsBlog.Repository;
using TayfunsBlog.Repository.Repositories;
using TayfunsBlog.Repository.UnitOfWorks;
using TayfunsBlog.Service.Mapping;
using TayfunsBlog.Service.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();



builder.Services.AddScoped(typeof(IGenericRepository<>), (typeof(GenericRepository<>)));
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped(typeof(IService<>), (typeof(Service<>)));
builder.Services.AddAutoMapper(typeof(MapProfile));
builder.Services.AddScoped<IPostRepository, PostRepository>();
builder.Services.AddScoped<IPostService, PostService>();


builder.Services.AddDbContext<AppDbContext>(
            options => options.UseSqlServer("name=ConnectionStrings:DefaultConnection").UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));



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
    pattern: "{controller=Default}/{action=Index}/{id?}");

app.Run();

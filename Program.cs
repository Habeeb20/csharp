var builder = WebApplication.CreateBuilder(args);
// var startup = new Startup(builder.configuration);
// startup.configureService(builder.Services);
// var app = builder.Build();
// startup.Configure(app, builder.Environment);


// Add services to the container.

builder.Services.AddControllersWithViews();
// builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlite(
//             Configuration.GetConnecttionString("DefaultConnection")
//         ));
// builder.Services.AddDatabaseDeveloperPageExceptionFilter();

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

using Lana_jewelry.Data;
using Lana_jewelry.Domain;
using Lana_jewelry.Domain.Party;
using Lana_jewelry.Domain.Shipment;
using Lana_jewelry.Infra;
using Lana_jewelry.Infra.Initializers;
using Lana_jewelry.Infra.Party;
using Lana_jewelry.Infra.Shipment;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(o => o.UseSqlServer(connectionString));
builder.Services.AddDbContext<Lana_jewelryDb>(o => o.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddRazorPages(o=> {
    o.Conventions.AuthorizePage("/Countries/Create");
    o.Conventions.AuthorizePage("/Countries/Delete");
    o.Conventions.AuthorizePage("/Countries/Edit");
    o.Conventions.AuthorizePage("/Currencies/Create");
    o.Conventions.AuthorizePage("/Currencies/Delete");
    o.Conventions.AuthorizePage("/Currencies/Edit");
});
builder.Services.AddTransient<ICostumersRepo, CostumersRepo>();
builder.Services.AddTransient<IInfoRepo, InfoRepo>();
builder.Services.AddTransient<IJewelryRepo, JewelryRepo>();
builder.Services.AddTransient<IShoppingBagRepo, ShoppingBagRepo>();
builder.Services.AddTransient<ITransportsRepo, TransportsRepo>();
builder.Services.AddTransient<IGiftCardRepo, GiftCardRepo>();
builder.Services.AddTransient<ICountriesRepo, CountriesRepo>();
builder.Services.AddTransient<ICurrenciesRepo, CurrenciesRepo>();
builder.Services.AddTransient<ICountryCurrenciesRepo, CountryCurrenciesRepo>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
using (var scope = app.Services.CreateScope()){
    GetRepo.SetService(app.Services);
    var db = scope.ServiceProvider.GetService<Lana_jewelryDb>();
    _= (db?.Database?.EnsureCreated());
    Lana_jewelryDbInitializer.Init(db);
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();

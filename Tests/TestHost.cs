using Lana_jewelry.Data;
using Lana_jewelry.Infra;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Lana_jewelry.Tests {
    public class TestHost<TProgram> : WebApplicationFactory<TProgram> where TProgram : class {
        protected override void ConfigureWebHost(IWebHostBuilder b) {
            base.ConfigureWebHost(b);
            b.ConfigureTestServices(s=> {
                removeDb<ApplicationDbContext>(s);
                removeDb<Lana_jewelryDb>(s);
                s.AddEntityFrameworkInMemoryDatabase();
                addDb<ApplicationDbContext>(s);
                addDb<Lana_jewelryDb>(s);
                ensureCreated(s, typeof(ApplicationDbContext), typeof(Lana_jewelryDb)); 
            });
        }
        private void ensureCreated(IServiceCollection s, params Type[] types) {
            var sp=s.BuildServiceProvider();
            using (var scope = sp.CreateScope()) {
                var scopedServices = scope.ServiceProvider;
                foreach (var type in types) ensureCreated(scopedServices, type);
            }
        }
        private static void ensureCreated(IServiceProvider s, Type t) {
            if (s?.GetRequiredService(t) is not DbContext c)
                throw new ApplicationException($"DBContext {t} not found");
            c?.Database?.EnsureCreated();
            if(! (c?.Database?.IsInMemory()?? false))
                    throw new ApplicationException($"DBContext {t} is not in memory");
        }
        private static void addDb<T>(IServiceCollection s) where T : DbContext
            => s?.AddDbContext<T>(o => { o.UseInMemoryDatabase("Tests"); });
        private static void removeDb<T>(IServiceCollection s) where T:DbContext {
            var descriptor = s.SingleOrDefault(d => d.ServiceType == typeof(DbContextOptions<T>));
            if (descriptor is not null) { s?.Remove(descriptor); }
        }
    }
}

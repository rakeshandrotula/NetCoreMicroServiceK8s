using PlatformService.Models;

namespace PlatformService.Data
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
            }
        }

        private static void SeedData(AppDbContext context)
        {
            if (!context.Platforms.Any())
            {
                Console.WriteLine("Getting Data!!!");
                context.Platforms.AddRange(
                    new Platform { Name = "Rakesh", Publisher = "Androtula", Cost = "Costly" },
                    new Platform { Name = "Rakesh1", Publisher = "Androtula1", Cost = "Costly1" },
                    new Platform { Name = "Rakesh2", Publisher = "Androtula2", Cost = "Costly2" },
                    new Platform { Name = "Rakesh3", Publisher = "Androtula3", Cost = "Costly3" });
                context.SaveChanges();
            }
            else { Console.WriteLine("We have data!!!"); }
        }
    }
}
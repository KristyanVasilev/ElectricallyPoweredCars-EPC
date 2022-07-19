using EPC.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EPC.Infrastructure.Data
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder PrepareDatabase(this IApplicationBuilder app)
        {
            using var scopedServices = app.ApplicationServices.CreateScope();

            var data = scopedServices.ServiceProvider.GetService<EpcDbContext>();

            data.Database.Migrate();
            SeedCategories(data);

            return app;
        }

        private static void SeedCategories(EpcDbContext data)
        {
            if (data.Categories.Any())
            {
                return;
            }

            data.Categories.AddRange(new[]
            {
                new Category { Name = "Electric Minicar" },
                new Category { Name = "Electric SUV" },
                new Category { Name = "Electric Sedan" }
            });

            data.SaveChanges();
        }
    }
}

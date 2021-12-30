namespace MyRecipes.Data.Seeding
{
    using MyRecipes.Data.Models;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public class CategoriesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Categories.Any())
            {
                return;
            }

            await dbContext.Categories.AddAsync(new Category { Name = "Тарт" });
            await dbContext.Categories.AddAsync(new Category { Name = "Десерти" });
            await dbContext.Categories.AddAsync(new Category { Name = "Салати" });
            await dbContext.Categories.AddAsync(new Category { Name = "Аламинути" });

            await dbContext.SaveChangesAsync();
        }
    }
}

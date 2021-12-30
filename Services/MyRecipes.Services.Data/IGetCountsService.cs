namespace MyRecipes.Services.Data
{
    using MyRecipes.Services.Data.Models;

    public interface IGetCountsService
    {
        // 1. Use the view model - lazy but fast way
        // 2. Create DTO -> view model
        CountsDto GetCounts();
    }
}

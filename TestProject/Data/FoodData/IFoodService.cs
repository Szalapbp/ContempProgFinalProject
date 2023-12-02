using ContempProgFinalProject.Models;

namespace ContempProgFinalProject.Data.FoodData
{
    public interface IFoodService
    {
        List<Food> GetAllProducts();
        Food GetFoodById(int Id);
    }
}

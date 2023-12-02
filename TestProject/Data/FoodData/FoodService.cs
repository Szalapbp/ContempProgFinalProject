using ContempProgFinalProject.Data.TeamMemberData;
using ContempProgFinalProject.Models;

namespace ContempProgFinalProject.Data.FoodData
{
    public class FoodService : IFoodService
    {
        FoodContext ctx;
        public FoodService(FoodContext context)
        {
            ctx = context;
        }
        List<Food> IFoodService.GetAllProducts()
        {
            return ctx.Food.ToList();
        }

        Food IFoodService.GetFoodById(int Id)
        {
            return ctx.Food.FirstOrDefault(x => x.Id == Id);
        }
    }
}

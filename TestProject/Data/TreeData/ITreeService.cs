using ContempProgFinalProject.Models;
namespace ContempProgFinalProject.Data.TreeData
{
    public interface ITreeService
    {
        List<Tree> GetAllProducts();
        Tree GetTreeById(int Id);

    }
}

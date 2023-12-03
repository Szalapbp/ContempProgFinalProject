using ContempProgFinalProject.Models;
namespace ContempProgFinalProject.Data.TreeData
{
    public class TreeService : ITreeService
    {
        TreeContext ctx;
        public TreeService(TreeContext context)
        {
            ctx = context;
        }
        List<Tree> ITreeService.GetAllProducts()
        {
            return ctx.Tree.ToList();
        }

        Tree ITreeService.GetTreeById(int Id)
        {
            return ctx.Tree.FirstOrDefault(x => x.Id == Id);
        }
    }
}

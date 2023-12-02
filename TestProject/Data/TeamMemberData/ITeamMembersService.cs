using ContempProgFinalProject.Models;
namespace ContempProgFinalProject.Data.TeamMemberData
{
    public interface ITeamMembersService
    {
        List<TeamMembers> GetAllProducts();
        TeamMembers GetMemberById(int Id);

    }
}

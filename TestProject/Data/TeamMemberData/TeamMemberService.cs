using ContempProgFinalProject.Models;
namespace ContempProgFinalProject.Data.TeamMemberData
{
    public class TeamMemberService : ITeamMembersService
    {
        TeamMemberContext ctx;
        public TeamMemberService(TeamMemberContext context)
        {
            ctx = context;
        }
        List<TeamMembers> ITeamMembersService.GetAllProducts()
        {
            return ctx.Members.ToList();
        }

        TeamMembers ITeamMembersService.GetMemberById(int Id)
        {
            return ctx.Members.FirstOrDefault(x => x.Id == Id);
        }
    }
}

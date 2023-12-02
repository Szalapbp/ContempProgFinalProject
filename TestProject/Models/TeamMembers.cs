namespace ContempProgFinalProject.Models
{
    public class TeamMembers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Birthdate { get; set; }
        public string CollegeProgram { get; set; }
        public int CollegeYear { get; set; }

        public string GetText()
        {
            return $"{Id} \t {Name} \t {Birthdate} \t {CollegeProgram} \t {CollegeYear}";
        }
    }
}

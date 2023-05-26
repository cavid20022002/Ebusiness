using eBusinessTemplate.Models;

namespace eBusinessTemplate.ViewModels
{
    public class HomeVM
    {
        public List<Blog>Blogs { get; set; }
        public List<CustomService>CustomServices { get; set; }
        public List<TeamMember>TeamMembers { get; set; }
    }
}

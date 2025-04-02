namespace WebApplication1.Models
{
    public class EditUserViewModel
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Voornaam { get; set; }

        public List<RoleCheck> Roles { get; set; }
    }

    public class RoleCheck
    {
        public string Role { get; set; }
        public bool IsSelected { get; set; }
    }
}

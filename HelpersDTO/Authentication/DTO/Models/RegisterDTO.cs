namespace HelpersDTO.Authentication.DTO.Models
{
    public class RegisterDTO
    {
        public string Email { get; set; }
        public string? Phone { get; set; }
        public string Password { get; set; }
        public RoleDTO? Role { get; set; }
    }
}

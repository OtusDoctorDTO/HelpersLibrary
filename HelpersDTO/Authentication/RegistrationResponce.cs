namespace HelpersDTO.Authentication
{
    public class RegistrationResponse
    {
        public bool? Flag { get; set; }
        public List<string>? Messages { get; set; }
        public string? Token { get; set; }
        public Guid? UserId { get; set; }
    }
}

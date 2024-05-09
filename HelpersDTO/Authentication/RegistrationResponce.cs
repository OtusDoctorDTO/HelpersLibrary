namespace HelpersDTO.Authentication
{
    public class RegistrationResponse
    {
        public bool Flag { get; }
        public List<string> Messages { get; set; } = new();
        public string? Token { get; set; } = string.Empty;
        public RegistrationResponse(bool flag)
        {
            Flag = flag;
        }
    }
}

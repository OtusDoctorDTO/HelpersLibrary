namespace HelpersDTO.Authentication
{
    public class RegistrationResponse
    {
        public bool Flag { get; }
        public List<string> Messages { get; set; } = new();
        public string? Token { get; set; } = string.Empty;
        public Guid? UserId { get; set; }
        public RegistrationResponse(bool flag)
        {
            Flag = flag;
        }
        public RegistrationResponse(bool flag, List<string> messages, string? token, Guid? userId)
        {
            Flag = flag;
            Messages = messages;
            Token = token;
            UserId = userId;
        }

        public RegistrationResponse(){}
    }
}

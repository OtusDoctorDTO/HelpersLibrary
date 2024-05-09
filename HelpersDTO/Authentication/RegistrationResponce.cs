namespace HelpersDTO.Authentication
{
    public record RegistrationResponse(bool Flag = false, List<string> Messages = null!, string? token = null!);
}

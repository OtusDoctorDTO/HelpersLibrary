namespace HelpersDTO.Authentication
{
    public record LoginResponse(bool Flag = false, string Message = null!, string? token = null!);
}

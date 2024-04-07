namespace HelpersDTO.Base
{
    public class ServiceResponse
    {
        public Guid Guid { get; set; }

        public bool Success { get; set; }

        public string Message { get; set; }

        public string ConnectionId { get; set; }
    }
}

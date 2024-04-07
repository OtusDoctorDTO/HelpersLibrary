namespace HelpersDTO.Base
{
    /// <summary>
    /// Базовый класс запроса данных
    /// </summary>
    public class ServiceRequest
    {
        public Guid Guid { get; set; }
        public string ConnectionId { get; set; }
    }
}

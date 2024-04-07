namespace HelpersDTO.CallCenter.DTO.Models
{
    /// <summary>
    /// Контакты
    /// </summary>
    public class ContactDTO
    {
        /// <summary>
        /// Мобильный телефон
        /// </summary>
        public string MobilePhone { get; set; }
        /// <summary>
        /// Домашний телефон
        /// </summary>
        public string HomePhone { get; set; }
        /// <summary>
        /// Электронная почта
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Основной способ связи?
        /// </summary>
        public bool Default { get; set; }
    }
}

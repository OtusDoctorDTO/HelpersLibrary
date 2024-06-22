using HelpersDTO.Base.Models;

namespace HelpersDTO.Doctor.DTO.Models
{
    /// <summary>
    /// Сущность для создания нового доктора
    /// </summary>
    public class NewDoctorDTO
    {
        /// <summary>
        /// ФИО
        /// </summary>
        public BaseUserDTO? User { get; set; }

        /// <summary>
        /// Контакты
        /// </summary>
        public ContactDTO? Contacts { get; set; }

        /// <summary>
        /// Специальность
        /// </summary>
        public string? Specialty { get; set; }
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        public string? Email { get; set; }
        /// <summary>
        /// Телефон
        /// </summary>
        public string? Phone { get; set; }

        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        public Guid? UserId { get; set; }
    }
}

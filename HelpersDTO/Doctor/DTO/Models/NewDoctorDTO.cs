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
    }
}

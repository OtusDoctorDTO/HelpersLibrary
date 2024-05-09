using HelpersDTO.Base.Models;

namespace HelpersDTO.Doctor.DTO.Models
{
    /// <summary>
    /// Доктор
    /// </summary>
    public class ShortDoctorDTO
    {
        public Guid Id { get; set; }

        /// <summary>
        /// ФИО
        /// </summary>
        public BaseUserDTO User { get; set; }

        /// <summary>
        /// Специальность
        /// </summary>
        public string Specialty { get; set; }
    }
}

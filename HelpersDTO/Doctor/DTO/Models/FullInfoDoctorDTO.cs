using HelpersDTO.Base.Models;

namespace HelpersDTO.Doctor.DTO.Models
{
    /// <summary>
    /// Полная информация о докторе !
    /// </summary>
    public class FullInfoDoctorDTO
    {
        public Guid? Id { get; set; }

        /// <summary>
        /// Персональная информация о докторе
        /// </summary>
        public BaseUserDTO? UserInfo { get; set; }
        
        /// <summary>
        /// Дата начала работы (для вычисления стажа)
        /// </summary>
        public DateTime? StartWorkDate { get; set; }
        
        /// <summary>
        /// Кабинет
        /// </summary>
        public string? Cabinet { get; set; }

        /// <summary>
        /// График работы
        /// </summary>
        public Dictionary<DateOnly, IntervalDTO?>? IntervalInfo { get; set; }
    }
}

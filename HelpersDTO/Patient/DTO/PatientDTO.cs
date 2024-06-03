using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpersDTO.Patient.DTO
{
    public class PatientDTO
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string? LastName { get; set; }
        /// <summary>
        /// Имя
        /// </summary>
        public string? FirstName { get; set; }
        /// <summary>
        /// Отчество
        /// </summary>
        public string? MiddleName { get; set; }

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

        /// <summary>
        /// Статус
        /// </summary>
        public string? Status { get; set; } = default;

        /// <summary>
        /// Является ли новым пациентом и нужно составить договор
        /// </summary>
        public bool IsNew { get; set; } = default;
    }
}

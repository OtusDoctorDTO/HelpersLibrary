﻿using HelpersDTO.Base.Models;

namespace HelpersDTO.Doctor.DTO
{
    /// <summary>
    /// Доктор
    /// </summary>
    public class DoctorDTO
    {
        public int Id { get; set; }

        /// <summary>
        /// ФИО
        /// </summary>
        public BaseUserDTO User { get; set; }

        /// <summary>
        /// Контакты
        /// </summary>
        public ContactDTO Contacts { get; set; }

        /// <summary>
        /// Специальность
        /// </summary>
        public string Specialty { get; set; }
    }
}

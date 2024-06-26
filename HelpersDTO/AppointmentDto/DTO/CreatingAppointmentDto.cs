﻿using HelpersDTO.AppointmentDto.Enums;

namespace HelpersDTO.AppointmentDto.DTO
{
    /// <summary>
    /// ДТО записи
    /// </summary>
    public class CreatingAppointmentDto
    {
        /// <summary>
        /// Стоимость
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Продолжительность приема
        /// </summary>
        public DurationEnum Duration { get; set; }
        /// <summary>
        /// Время начала записи
        /// </summary>
        public DateTime Time { get; set; }
        /// <summary>
        /// Идентификатор врача
        /// </summary>
        public Guid? DoctorId { get; set; }
        /// <summary>
        /// Идентификатор пациента
        /// </summary>
        public Guid? PatientId { get; set; }
        /// <summary>
        /// Жалобы
        /// </summary>
        public string? Complaints { get; set; }
        /// <summary>
        /// Рекомендации к лечению
        /// </summary>
        public string? Recommendations { get; set; }
        public bool IsCompleted { get; set; } = false;
    }
}
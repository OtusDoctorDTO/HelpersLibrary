﻿namespace HelpersDTO.Authentication
{
    public class ShortAppointmentRequest
    {
        /// <summary>
        /// C
        /// </summary>
        public DateTime? SinceDate { get; set; }
        /// <summary>
        /// По
        /// </summary>
        public DateTime? ForDate { get; set; }
        /// <summary>
        /// Список статусов
        /// </summary>
        public int[]? Statuses { get; set; }

        /// <summary>
        /// Количество записей
        /// </summary>
        public int? Count { get; set; }
    }
}

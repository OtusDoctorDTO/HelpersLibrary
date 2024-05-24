namespace HelpersDTO.AppointmentDto.DTO
{
    public class ShortAppointnmentDTO
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Стоимость
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Полное время начала записи
        /// </summary>
        public DateTime StartDate { get; set; }
        /// <summary>
        /// Идентификатор врача
        /// </summary>
        public Guid DoctorId { get; set; }
        /// <summary>
        /// Только дата начала записи
        /// </summary>
        public DateOnly Date { get; set; }
        /// <summary>
        /// Только время начала записи
        /// </summary>
        public TimeOnly Time { get; set; }
    }
}

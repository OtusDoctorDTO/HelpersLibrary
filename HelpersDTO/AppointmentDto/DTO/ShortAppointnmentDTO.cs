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
        /// Время начала записи
        /// </summary>
        public DateTime StartDate { get; set; }
        /// <summary>
        /// Идентификатор врача
        /// </summary>
        public Guid DoctorId { get; set; }
    }
}

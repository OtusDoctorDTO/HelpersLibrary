namespace HelpersDTO.Patient.DTO
{
    /// <summary>
    /// Паспорт пациента
    /// </summary>
    public class PassportDTO
    {
        /// <summary>
        /// Серия
        /// </summary>
        public string? Series { get; set; }

        /// <summary>
        /// Номер
        /// </summary>
        public string? Number { get; set; }

        /// <summary>
        /// Дата выдачи
        /// </summary>
        public DateTime? IssueDate { get; set; }

        /// <summary>
        /// Код подразделения
        /// </summary>
        public string? SubdivisionCode { get; set; }

        /// <summary>
        /// Кем выдан
        /// </summary>
        public string? IssuedBy { get; set; }
    }
}

using HelpersDTO.AppointmentDto.Enums;

namespace HelpersDTO.AppointmentDto.DTO
{
    /// <summary>
    /// ДТО редактируемой записи
    /// </summary>
    public class UpdateStatusAppointmentDto
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Идентификатор пациента (если он не указан, то обновляться не будет)
        /// </summary>
        public Guid? PatientId { get; set; }

        /// <summary>
        /// Статус
        /// </summary>
        public int Status { get; set; }
    }
}
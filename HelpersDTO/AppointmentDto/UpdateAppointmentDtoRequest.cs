using HelpersDTO.AppointmentDto.DTO;
using HelpersDTO.Base;

namespace HelpersDTO.AppointmentDto
{
    public class UpdateAppointmentDtoRequest : ServiceRequest
    {
        public Guid Id { get; set; }

        /// <summary>
        /// Запись
        /// </summary>
        public UpdatingAppointmentDto Appointment {  get; set; }
    }
}

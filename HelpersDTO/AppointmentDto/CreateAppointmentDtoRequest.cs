using HelpersDTO.AppointmentDto.DTO;
using HelpersDTO.Base;

namespace HelpersDTO.AppointmentDto
{
    public class CreateAppointmentDtoRequest : ServiceRequest
    {
        /// <summary>
        /// Запись
        /// </summary>
        CreatingAppointmentDto Appointment {  get; set; }
    }
}

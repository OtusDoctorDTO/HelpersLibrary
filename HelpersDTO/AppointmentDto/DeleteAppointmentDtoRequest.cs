using HelpersDTO.Base;

namespace HelpersDTO.AppointmentDto
{
    public class DeleteAppointmentDtoRequest : ServiceRequest
    {
        public Guid Id { get; set; }
    }
}

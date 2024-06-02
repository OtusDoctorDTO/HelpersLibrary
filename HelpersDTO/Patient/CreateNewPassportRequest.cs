using HelpersDTO.Base;
using HelpersDTO.Patient.DTO;

namespace HelpersDTO.Patient
{
    public class CreateNewPassportRequest : ServiceRequest
    {
        public Guid? UserId { get; set; }
        public PassportDTO? Passport { get; set; }
    }
}

using HelpersDTO.Base;
using HelpersDTO.Doctor.DTO.Models;

namespace HelpersDTO.Doctor.DTO
{
    public class GetDoctorsDTORequest : ServiceRequest
    {
        /// <summary>
        /// Список докторов
        /// </summary>
        public List<DoctorDTO> Doctors { get; set; }
    }
}

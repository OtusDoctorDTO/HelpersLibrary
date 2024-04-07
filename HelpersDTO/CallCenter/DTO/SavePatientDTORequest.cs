using HelpersDTO.Base;
using HelpersDTO.CallCenter.DTO.Models;

namespace HelpersDTO.CallCenter.DTO
{
    /// <summary>
    /// Модель пациента
    /// </summary>
    public class SavePatientDTORequest : ServiceRequest
    {
        public PatientDto Patient { get; set; }
    }
}

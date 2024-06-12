using HelpersDTO.Base;
using HelpersDTO.Patient.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpersDTO.Patient
{
    public class CreatePatientRequest : ServiceRequest
    {
        public PatientDTO? Patient { get; set; }
    }
}

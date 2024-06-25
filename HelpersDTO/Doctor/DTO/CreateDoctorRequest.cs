using HelpersDTO.Base;
using HelpersDTO.Doctor.DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpersDTO.Doctor.DTO
{
    public class CreateDoctorRequest : ServiceRequest
    {
        public NewDoctorDTO? Doctor { get; set; }
    }
}

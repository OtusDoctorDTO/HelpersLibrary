﻿namespace HelpersDTO.CallCenter.DTO.Models
{
    public class PatientDto
    {
        /// <summary>
        /// Id пользователя
        /// </summary>
        public Guid UserId { get; set; }
        /// <summary>
        /// Данные документа
        /// </summary>
        public DocumentDTO Document { get; set; }
        public List<ContactDTO> Contacts { get; set; }
        /// <summary>
        /// Статус пациента
        /// </summary>
        public RelevanceStatusEnum Status { get; set; } = RelevanceStatusEnum.New;
    }
}

namespace HelpersDTO.Doctor.DTO.Models
{
    /// <summary>
    /// Прометожуток С ПО
    /// </summary>
    public class IntervalDTO
    {
        public TimeOnly SinceTime {  get; set; }
        public TimeOnly ForTime { get; set; }
    }
}

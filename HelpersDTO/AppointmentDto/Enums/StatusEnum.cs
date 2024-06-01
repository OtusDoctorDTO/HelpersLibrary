using System.ComponentModel;

namespace HelpersDTO.AppointmentDto.Enums
{
    /// <summary>
    /// Статус записи
    /// </summary>
    public enum StatusEnum
    {
        [Description("")]
        None = 0,
        [Description("Свободно")]
        Free,
        [Description("Забронировано пользователем")]
        BookedByUser,
        [Description("В ожидании приема")]
        Waiting,
        [Description("Прием начат")]
        InProccess,
        [Description("Завершено")]
        Success,
        [Description("Отменено")]
        Сanceled
    }
}

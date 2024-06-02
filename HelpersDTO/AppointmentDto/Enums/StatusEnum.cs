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
        /// <summary>
        /// Свободная запись
        /// </summary>
        [Description("Свободно")]
        Free,
        /// <summary>
        /// Пользователь записался самостоятельно на сайте
        /// </summary>
        [Description("Забронировано пользователем")]
        BookedByUser,
        /// <summary>
        /// Когда в колл центре подтвердили запись
        /// </summary>
        [Description("Подтверждено")]
        Confirmed,
        /// <summary>
        /// В ожидании приема в клинике
        /// </summary>
        [Description("В ожидании приема")]
        Waiting,
        /// <summary>
        /// Доктор начал прием
        /// </summary>
        [Description("Прием начат")]
        InProccess,
        /// <summary>
        /// Запись завершена
        /// </summary>
        [Description("Завершено")]
        Success,
        /// <summary>
        /// Запись отменена
        /// </summary>
        [Description("Отменено")]
        Сanceled
    }
}

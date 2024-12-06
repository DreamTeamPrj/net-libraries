namespace System.BaseLayers.Core.Entities
{
    /// <summary>
    /// Базовая сущность с данными о создании
    /// </summary>
    /// <typeparam name="TId">Тип идентификатор</typeparam>
    public abstract class AuditableEntity<TId> : BaseEntity<TId>
    {
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Дата обновления
        /// </summary>
        public DateTime UpdatedDate { get; set; }
    }
}
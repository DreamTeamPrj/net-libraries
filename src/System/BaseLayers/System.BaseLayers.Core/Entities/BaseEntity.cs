namespace System.BaseLayers.Core.Entities
{
    /// <summary>
    /// Базовая сущность
    /// </summary>
    /// <typeparam name="TId">Тип идентификатора</typeparam>
    public abstract class BaseEntity<TId>
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public TId Id { get; set; }
    }
}
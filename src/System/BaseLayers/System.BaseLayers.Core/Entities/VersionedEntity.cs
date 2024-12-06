namespace System.BaseLayers.Core.Entities
{
    /// <summary>
    /// Версионированная сущность
    /// </summary>
    /// <typeparam name="TId">Тип идентификатора</typeparam>
    public abstract class VersionedEntity<TId> : AuditableEntity<TId>
    {
        /// <summary>
        /// Идентификатор предыдущей версии
        /// </summary>
        public TId? PreviousVersionId { get; set; }

        /// <summary>
        /// Является ли сущность последней версией
        /// </summary>
        public bool IsLast { get; set; }
    }
}
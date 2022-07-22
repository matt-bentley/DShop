﻿
namespace DShop.SharedKernel
{
    public interface IRepository<T> where T : AggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
        IQueryable<T> GetAll(bool noTracking = true);
        Task<T> GetByIdAsync(Guid id);
        Task InsertAsync(T entity);
        void Delete(T entity);
        void Remove(IEnumerable<T> entitiesToRemove);
    }
}

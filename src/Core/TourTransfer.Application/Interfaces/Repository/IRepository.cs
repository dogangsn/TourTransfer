using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourTransfer.Domain.Common;

namespace TourTransfer.Application.Interfaces.Repository
{
    public interface IRepository<T> where T : BaseEntity, new()
    {
        Task<List<T>> GetAsync();
        Task<T> GetByIdAsync(Guid id);
        Task<T> AddAsync(T entity);
    }
}

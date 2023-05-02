using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourTransfer.Application.Interfaces.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        //IDbContextTransaction : EntityFrameworkCore kütüphanesine ihtiyaç vardır.
        Task<IDbContextTransaction> BeginTransactionAsync();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
        List<T> Query<T>(string query, object parameters);
        List<T> Query<T>(string query);
        void Commit();
        void Rollback();

    }
}

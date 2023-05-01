using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourTransfer.Application.Interfaces.UnitOfWork
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        //IDbContextTransaction : EntityFrameworkCore kütüphanesine ihtiyaç vardır.
        Task<IDbContextTransaction> BeginTransactionAsync();
        
    }
}

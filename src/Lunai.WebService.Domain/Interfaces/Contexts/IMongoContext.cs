using MongoDB.Driver;
using System;
using System.Threading.Tasks;

namespace Lunai.WebService.Domain.Interfaces.Context
{
    public interface IMongoContext : IDisposable
    {
        IMongoCollection<T> GetCollection<T>(string v);

        Task<int> SaveChanges();

        void AddCommand(Func<Task> func);
    }
}

using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lunai.WebService.Infrastructure.Data.MongoDB.Contexts
{
    public interface IMongoContext : IDisposable
    {
        IMongoCollection<T> GetCollection<T>(string v);
    }
}

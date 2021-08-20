using Lunai.WebService.Domain.Entities.MongoDocuments.ExpertDocuments;
using Lunai.WebService.Domain.Interfaces.Repositories;
using Lunai.WebService.Infrastructure.Data.MongoDB.Contexts;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lunai.WebService.Infrastructure.Data.MongoDB.Repositories
{
    public class ExpertRepository : IExpertRepository
    {
        protected readonly MongoContext _context;
        protected readonly IMongoCollection<ExpertDocument> DbSet;

        protected ExpertRepository(MongoContext context)
        {
            _context = context;
            DbSet = _context.GetCollection<ExpertDocument>("Experts");
        }

        public async Task<IEnumerable<ExpertDocument>> GetAll()
        {
            var data = await DbSet.FindAsync(Builders<ExpertDocument>.Filter.Empty);
            return data.ToList();
        }

        public async Task<ExpertDocument> GetById(string idExpert)
        {
            var data = await DbSet.FindAsync(Builders<ExpertDocument>.Filter.Eq("_id", idExpert));
            return data.FirstOrDefault();
        }
    }
}

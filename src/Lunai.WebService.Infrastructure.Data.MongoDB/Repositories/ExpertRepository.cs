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
        protected readonly IMongoContext _context;
        protected readonly IMongoCollection<ExpertDocument> DbSet;

        public ExpertRepository(IMongoContext context)
        {
            _context = context;
            DbSet = _context.GetCollection<ExpertDocument>("Experts");
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public async Task<IEnumerable<ExpertDocument>> GetAll()
        {
            try
            {
                var data = await DbSet.FindAsync(Builders<ExpertDocument>.Filter.Empty);
                return data.ToList();    
            }
            catch (System.Exception ex)
            {
                var teste = ex.Message;
                throw;
            }
        }

        public async Task<ExpertDocument> GetById(string idExpert)
        {
            var data = await DbSet.FindAsync(x => x.Id == idExpert);
            return data.FirstOrDefault();
        }
    }
}

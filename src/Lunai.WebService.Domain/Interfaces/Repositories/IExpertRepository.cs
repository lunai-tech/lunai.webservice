using Lunai.WebService.Domain.Entities.MongoDocuments.ExpertDocuments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lunai.WebService.Domain.Interfaces.Repositories
{
    public interface IExpertRepository
    {
        Task<ExpertDocument> GetById(string idExpert);

        Task<IEnumerable<ExpertDocument>> GetAll();
    }
}

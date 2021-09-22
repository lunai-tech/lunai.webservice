using Lunai.WebService.Application.ViewModel.Response.Experts;
using Lunai.WebService.Domain.Entities.MongoDocuments.ExpertDocuments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lunai.WebService.Application.Mappings.ExpertMapping
{
    public static class ListExpertMapping
    {
        public static ExpertListModelResponse DocumentToModel(IEnumerable<ExpertDocument> document)
        {
            var expertResponse = new ExpertListModelResponse();

            return expertResponse;
        }
    }
}

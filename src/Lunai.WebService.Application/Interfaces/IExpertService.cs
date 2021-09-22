using Lunai.WebService.Application.ViewModel.Response.Experts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lunai.WebService.Application.Interfaces
{
    public interface IExpertService
    {
        Task<ExpertListModelResponse> ListExperts();

        Task<ExpertListModelResponse> ListExpertsBySkill(string skill);
    }
}

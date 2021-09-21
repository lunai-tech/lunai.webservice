using Lunai.WebService.Application.Interfaces;
using Lunai.WebService.Application.ViewModel.Response.Experts;
using Lunai.WebService.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lunai.WebService.Application.Services
{
    public class ExpertService : IExpertService
    {
        private readonly IExpertRepository _expertRepository;

        public ExpertService(IExpertRepository expertRepository)
        {
            _expertRepository = expertRepository;
        }

        public async Task<ExpertListModelResponse> ListExperts()
        {
            var result = new ExpertListModelResponse();

            var experts = await _expertRepository.GetAll();

            experts.ToList().ForEach(x =>
            {
                var rating = x.Jobs.Where(x => x.Status == "Finalizado").Sum(x => x.RatingJob) / x.Jobs.Where(x => x.Status == "Finalizado").Count();
                result.Experts.Add(new ExpertModelResponse() { Nickname = x.Nickname, Rating = rating, Skill = x.Skills.First(), UrlPhoto = "" });
            });
            return result;
        }

        public Task<ExpertListModelResponse> ListExpertsBySkill(string skill)
        {
            throw new NotImplementedException();
        }
    }
}

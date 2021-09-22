using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lunai.WebService.Application.ViewModel.Response.Experts
{
    [DataContract]
    public class ExpertListModelResponse : BaseResponse
    {
        public ExpertListModelResponse()
        {
            Experts = new List<ExpertModelResponse>();
        }

        [DataMember]
        public List<ExpertModelResponse> Experts { get; set; }
    }
}

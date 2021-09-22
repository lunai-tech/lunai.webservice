using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lunai.WebService.Application.ViewModel.Response.Experts
{
    public class ExpertModelResponse
    {
        [DataMember]
        public string Nickname { get; set; }

        [DataMember]
        public int Rating { get; set; }

        [DataMember]
        public string Skill { get; set; }

        [DataMember]
        public string UrlPhoto { get; set; }
    }
}

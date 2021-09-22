using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lunai.WebService.Application.ViewModel.Response
{
    [DataContract]
    public abstract class BaseResponse
    {
        protected BaseResponse()
        {
            
        }

        [DataMember]
        public List<string> MessageErrors { get; set; }

        [DataMember]
        public bool Valid { get; set; }
    }
}

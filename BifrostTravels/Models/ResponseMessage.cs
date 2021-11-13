using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BifrostTravels.Models
{
    public class ResponseMessage
    {
        public bool IsSuccessful { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public Object ReturnObj { get; set; }

        /// <summary>
        /// Houses the data for the request made
        /// </summary>
        /// <param name="issuccessful"></param>
        /// <param name="statuscode"></param>
        /// <param name="returnobj"></param>
        public ResponseMessage(bool issuccessful, HttpStatusCode statuscode, Object returnobj)
        {
            IsSuccessful = issuccessful;
            StatusCode = statuscode;
            ReturnObj = returnobj;
        }
    }
}

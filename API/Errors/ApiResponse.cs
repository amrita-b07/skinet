using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Errors
{
    public class ApiResponse
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public ApiResponse(int statusCode, string message=null)
        {
            StatusCode = statusCode;
            Message = message?? GetDefaultMessageForStatusCode(statusCode);
        }

        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400=>"A bad request, you have made",
                401=>"Authorized, you are not",
                404=>"Resource found, it was not",
                500=>"Errors are path to the dark side",
                _=>null
            };
        }

    }
}
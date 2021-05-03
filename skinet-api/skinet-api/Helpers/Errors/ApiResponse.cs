using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace skinet_api.Helpers.Errors
{
    public class ApiResponse
    {
        /// <summary>
        /// Manage the error for better look of the API
        /// </summary>
        /// <param name="statusCode">
        /// Status code for the type of error
        /// 400 - BadRequest
        /// 401 - Not Authorized
        /// 404 - Not Found
        /// 500 - Error
        /// </param>
        /// <param name="message">
        /// Message that can be put to show custom or default message
        /// </param>
        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(statusCode);
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }

        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            // C# 8.0 switch syntax
            return statusCode switch
            {
                400 => "A bad request you have made",
                401 => "Authorized, you are not",
                404 => "Resource found, it was not",
                500 => "Erros are the path to the dark side. Errors lead to anger. Anger leads to hate. Hate leads to carrer change",
                _ => null
            };
        }
    }
}

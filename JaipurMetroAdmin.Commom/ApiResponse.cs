using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace JaipurMetroAdmin.Commom
{
    public class ApiResponse<T>
    {
        public HttpStatusCode StatusCode { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
        public T Response { get; set; }
        public ApiResponse(HttpStatusCode statusCode, int status, string message, T response)
        {
            StatusCode = statusCode;
            Status = status;
            Message = message;
            Response = response;
        }
    }
}

using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMiddlewareSample.web.Middleware
{
    public class CustomMiddleware
    {
        private readonly RequestDelegate _next;

        public CustomMiddleware(RequestDelegate _next) //, and other dependencies
        {
            this._next = _next;
        }
        public async Task Invoke(HttpContext context) //, and other dependencies)
        {
            //Middleware logic
            if (!context.Request.Headers.Values.Contains(""))
            {
                //logic
            }
            
            await _next.Invoke(context); //invoke next middleware (Required!)

            //Code executed after the next middleware

        }
    }
}

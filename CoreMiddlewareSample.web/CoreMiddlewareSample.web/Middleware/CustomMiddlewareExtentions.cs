using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMiddlewareSample.web.Middleware
{
    public static class CustomMiddlewareExtentions
    {
        public static IApplicationBuilder UseCustomMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<CustomMiddleware>();
            return app;
        }
    }
}

# CoreMiddlewareSample
A sample application showing how to implement custom middleware for .net Core

# Guide: 
Please find the Middleware directory, containing CustomMiddleware.cs and CustomMiddlewareExtentions.cs. The extentions add the possibility to use additional configuration options when first including your middleware in your IApplicationBuilder.

Methods are marked with required syntax, such as the Middleware invoking the middleware following it, to ensure the middleware chain isn't broken. 

A code sample has been included in Startup.cs showing how to not only register your CustomMiddleware, but also how to /conditionally/ invoke your middleware on a request. 

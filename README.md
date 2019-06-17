# Intro
In .net Core complex concepts like authentication and logging logic are abstracted through Middleware. The Startup.cs class enables us to easily add established, third party, and even our own custom services and middleware. 

This is a sample application showing how to implement custom middleware for .net Core

# Guide: 

Please find the Middleware directory, containing CustomMiddleware.cs and CustomMiddlewareExtentions.cs. The extentions add the possibility to use additional configuration options when first including your middleware in your IApplicationBuilder.

Methods are marked with required syntax, such as the Middleware invoking the middleware following it, to ensure the middleware chain isn't broken. 

A code sample has been included in Startup.cs showing how to not only register your CustomMiddleware, but also how to /conditionally/ invoke your middleware on a request. 

# What is middleware?

Your application middleware is a set of daisy-chained services which handle logic applied on all/select requests. Your request will get tunneled through your middleware classes before it gets delivered at your (Web)Controllers. This enables you to handle things like Authentication naturally, only providing the conditions needed to access the Controllers in the controllers themselves. Verifying which claims each user has, is handled in the Authentication middleware of Identity. 

Each middleware calls upon the next middleware as a rule.

![Middleware sample](https://www.tutorialsteacher.com/Content/images/core/middleware-1.png)

(Source: https://www.tutorialsteacher.com/core/aspnet-core-middleware)


As shown above, this not only allows us to modify the request itself, but also the response. Providing response headers to an Api call, to handle some Logging work after a request has finished, the sky's the limit.




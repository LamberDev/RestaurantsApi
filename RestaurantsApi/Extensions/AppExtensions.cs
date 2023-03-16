﻿using RestaurantsApi.Middlewares;

namespace RestaurantsApi.Extensions
{
    public static class AppExtensions
    {
        public static void UseErrorHandlingMiddleware(this IApplicationBuilder app) 
        {
            app.UseMiddleware<ErrorHandlerMiddleware>();
        }
    }
}

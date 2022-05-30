using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using RestSharp;

namespace BACK.PORTFOLIO.PortfolioVimeo
{
    public static class PortfolioVimeoRegistrar
    {
        public static IServiceCollection Register(IServiceCollection services)
        {
            //services.AddTransient<IBackgroundJobClient, BackgroundJobClient>();
            services.AddTransient<IRestClient, RestClient>();

            return services;
        }
    }
}

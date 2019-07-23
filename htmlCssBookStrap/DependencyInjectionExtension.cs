using BLL;
using BLL.Repoistory;
using Microsoft.Extensions.DependencyInjection;
using Servise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace htmlCssBookStrap
{
    public static class DependencyInjectionExtension
    {
        public static void AddService(this IServiceCollection services)
        {
            services.AddScoped<UserService,UserService>();
            services.AddScoped<SuggestService, SuggestService>();

        }

        public static void AddRepository(this IServiceCollection services)
        {
            services.AddScoped<UserRepository, UserRepository>();
            services.AddScoped<SuggestRepository, SuggestRepository>();
            services.AddScoped<EmailRepository, EmailRepository>();
        }
    }
}

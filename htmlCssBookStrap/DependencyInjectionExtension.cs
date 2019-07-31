using BLL;
using BLL.Repoistory;
using DBFactory;
using DBFactory.Suggest;
using htmlCssBookStrap.Pages;
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
            services.AddScoped<IProblemService, ProblemService>();
            services.AddScoped<CommentService, CommentService>();

        }

        public static void AddRepository(this IServiceCollection services)
        {
            services.AddScoped<UserRepository, UserRepository>();
            services.AddScoped<SuggestRepository, SuggestRepository>();
            services.AddScoped<EmailRepository, EmailRepository>();
            services.AddScoped<ProblemRepository, ProblemRepository>();
            services.AddScoped<CommentRepository, CommentRepository>();
        }

        //public static void AddFactory(this IServiceCollection services)
        //{
        //    services.AddScoped<RegisterFactory, RegisterFactory>();
        //    services.AddScoped<ProblemFactory, ProblemFactory>();
        //    services.AddScoped<NewFactory, NewFactory>();
        //}
    }
}

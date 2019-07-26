using AutoMapper;
using BLL;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servise
{
    public class BaseService
    {
        protected IHttpContextAccessor _accessor;
        protected static MapperConfiguration autoconfiguration;
        protected IMapper mapper
        {
            get
            {
                return autoconfiguration.CreateMapper();
            }
        }

        static BaseService()
        {
            autoconfiguration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Problem, DTOProblemModel>(MemberList.None)
                   .ForMember(p => p.Title, opt => opt.MapFrom(d => d.Content.Title))
                   .ForMember(p => p.Body, opt => opt.MapFrom(d => d.Content.Body));
                cfg.CreateMap<DTOProblemModel,Problem>(MemberList.None)
                    .ForMember(d=>d.Content,opt=>opt.MapFrom(p=>new Content { Title= p.Title, Body=p.Body }));

                //cfg.CreateMap<Bar, BarDto>();
            });
            // only during development, validate your mappings; remove it before release
            autoconfiguration.AssertConfigurationIsValid();
            // use DI (http://docs.automapper.org/en/latest/Dependency-injection.html) or create the mapper yourself
            
        }
        public BaseService()
        {

        }
        public BaseService(IHttpContextAccessor accessor)
        {
            _accessor = accessor;
        }

        protected User CurrentUser
        {
            get
            {
                string CurrentSession = _accessor.HttpContext.Session.GetString("Id");

                if (string.IsNullOrEmpty(CurrentSession))
                {
                    return null;
                }

                UserModel CurrentUserModel = JsonConvert.DeserializeObject<UserModel>(CurrentSession);
                return null;
            }
        }


    }
}

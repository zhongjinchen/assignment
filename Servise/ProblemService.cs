using AutoMapper;
using BLL;
using BLL.Repoistory;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Servise
{
    public class ProblemService:IProblemService
    {
        private ProblemRepository _problemRepository;
        private UserRepository _userRepository;
        private SQLContext _sqlContext;
        public ProblemService()
        {
            _sqlContext = new SQLContext();
            _problemRepository =new ProblemRepository(_sqlContext);
            _userRepository =new UserRepository(_sqlContext);
        }
        public ProblemService(SQLContext sqlContext, ProblemRepository problemRepository, UserRepository userRepository)
        {
            _sqlContext = sqlContext;
            _problemRepository = problemRepository;
            _userRepository = userRepository;
        }
        public ProblemService(ProblemRepository problemRepository, UserRepository userRepository)
        {
            _problemRepository = problemRepository;
            _userRepository = userRepository;
        }
        public Problem Publish(string title, string body, int authorId)
        {
            //Suggest suggest = new Suggest(new Content("title","body")
            //                 ,new Message(new UserRepoistory().GetById(authorId)));


            Problem problem = new Problem
            {
                Content =new Content {
                    Title = title,
                    Body=body
                },
                Message=new Message{ Author = _userRepository.GetById(authorId).SingleOrDefault() }
            };
            problem.Publish();
            return _problemRepository.Save(problem);
        }

        public DTOProblemModel Get(int id)
        {
            //var autoconfiguration = new MapperConfiguration(cfg =>
            //{
            //    cfg.CreateMap<Problem, DTOProblemModel>();
            //    //cfg.CreateMap<Bar, BarDto>();
            //});
            //// only during development, validate your mappings; remove it before release
            //autoconfiguration.AssertConfigurationIsValid();
            //// use DI (http://docs.automapper.org/en/latest/Dependency-injection.html) or create the mapper yourself
            //var mapper = autoconfiguration.CreateMapper();

            Problem problem=_problemRepository.GetById(id)
                .Include(p=>p.Content).SingleOrDefault();
            return /*mapper.Map<Problem,DTOProblemModel>(problem);*/
            new DTOProblemModel
            {
                Title = problem.Content.Title,
                Body = problem.Content.Body
            };
        }
    }

    public class DTOProblemModel
    {
        public string Title { get; set; }
        public string Body { get; set; }
    }
}

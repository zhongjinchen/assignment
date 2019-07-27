using AutoMapper;
using BLL;
using BLL.Repoistory;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;


namespace Servise
{
    public class ProblemService:BaseService,IProblemService
    {
        private ProblemRepository _problemRepository;
        private UserRepository _userRepository;

        //public DbSet<Problem> Problems {
        //    get
        //    {
        //        DbSet<Problem> problems = _problemRepository.entities.OrderByDescending(e => e.Id).;
        //        return problems;
        //    }
        //}

        public IList<Problem> GetAll()
        {
            return _problemRepository.GetAll();
        }
        public ProblemService( ProblemRepository problemRepository,
            UserRepository userRepository, IHttpContextAccessor accessor) : base(accessor)
        {
          
            _problemRepository = problemRepository;
            _userRepository = userRepository;
        }
   
        public Problem Publish(DTOProblemModel dtoProblemModel)
        {

            dtoProblemModel.User = CurrentUser;
            Problem problem = mapper.Map<DTOProblemModel, Problem>(dtoProblemModel);
         
            problem.Publish();
            return _problemRepository.Save(problem);
        }

        public DTOProblemModel Get(int id)
        {
          

            Problem problem=_problemRepository.GetById(id).SingleOrDefault();
            //.Include(p=>p.Content).SingleOrDefault();
            return mapper.Map<Problem, DTOProblemModel>(problem);

                    //new DTOProblemModel
                    //{
                    //    Title = problem.Content.Title,
                    //    Body = problem.Content.Body
                    //};
        }
    }

    public class DTOProblemModel
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Body { get; set; }

        public User User { get; set; }
    }
}

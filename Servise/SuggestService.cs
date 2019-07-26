using BLL;
using System;
using System.Collections.Generic;
using System.Text;
using BLL.Repoistory;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace Servise
{
    public class SuggestService:BaseService
    {
        private SuggestRepository _suggestRepository;
        private UserRepository _userRepository;
        private SQLContext _sqlContext;
        public SuggestService()
        {
            _sqlContext = new SQLContext();
            _suggestRepository =new SuggestRepository(_sqlContext);
            _userRepository = new UserRepository(_sqlContext);
        }
        public SuggestService(SuggestRepository suggestRepository, UserRepository userRepository, 
            IHttpContextAccessor accessor) : base(accessor)
        {
            _suggestRepository = suggestRepository;
            _userRepository = userRepository;
        }
        public Suggest Publish(string title, string body, int authorId)
        {
            //Suggest suggest = new Suggest(new Content("title","body")
            //                 ,new Message(new UserRepoistory().GetById(authorId)));
            
        
            Suggest suggest = new Suggest
            {
                Title = title,
                Body = body,
                Author = _userRepository.GetById(authorId).SingleOrDefault()
            };
            suggest.Publish();
            return _suggestRepository.Save(suggest);
        }
    }
}

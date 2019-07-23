using BLL;
using System;
using System.Collections.Generic;
using System.Text;
using BLL.Repoistory;

namespace Servise
{
    public class SuggestService
    {
        private SuggestRepository _suggestRepository;
        private UserRepository _userRepository;
        public SuggestService(SuggestRepository suggestRepository, UserRepository userRepository)
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
                Author = _userRepository.GetById(authorId)
            };
            suggest.Publish();
            return _suggestRepository.Save(suggest);
        }
    }
}

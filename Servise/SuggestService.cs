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
        public SuggestService()
        {
            _suggestRepository = new SuggestRepository();
        }
        public Suggest Publish(string title, string body, int authorId)
        {
            //Suggest suggest = new Suggest(new Content("title","body")
            //                 ,new Message(new UserRepoistory().GetById(authorId)));
            UserRepoistory userRepoistory = new UserRepoistory();
            userRepoistory.SetEntities(_suggestRepository.CurrentContext);
            Suggest suggest = new Suggest
            {
                Title = title,
                Body = body,
                Author = userRepoistory.GetById(authorId)
            };
            suggest.Publish();
            return _suggestRepository.Save(suggest);
        }
    }
}

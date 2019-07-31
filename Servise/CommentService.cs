using BLL;
using BLL.Model;
using BLL.Repoistory;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servise
{
    public class CommentService : BaseService
    {
        private ProblemRepository _problemRepository;
        private UserRepository _userRepository;
        private CommentRepository _commentRepository;
        public CommentService(ProblemRepository problemRepository,
                        UserRepository userRepository, CommentRepository commentRepository,
                        IHttpContextAccessor accessor) : base(accessor)
        {
            _commentRepository = commentRepository;
            _problemRepository = problemRepository;
            _userRepository = userRepository;
        }

        public void Publish(int id, string comment)
        {
            Problem problem = _problemRepository.GetById(id).SingleOrDefault();

            Comment Comment = new Comment
            {
                Body=comment,
                User=_userRepository.GetById(CurrentUser.Id).SingleOrDefault(),
                Problem=problem
            };

            Comment.Publish();

            _commentRepository.Save(Comment);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace assignment._17ban
{
    class Problem : IPublish<Problem>
    {
        public int Reward { get; set; }
        private Content Content;
        public Problem(Content content)
        {
            Content = content;
        }
        public void Public(TRepository<Problem> repository)
        {
            repository.Add(this);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace assignment
{
    class Suggest : IPublish<Suggest>
    {
        private Content Content;
        public Suggest(Content content)
        {
            Content = content;
        }
        public void Public(TRepository<Suggest> repository)
        {
            repository.Add(this);
        }
    }
}

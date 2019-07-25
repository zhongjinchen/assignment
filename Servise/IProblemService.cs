using BLL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servise
{
    public interface IProblemService
    {
        Problem Publish(string title, string body, int authorId);
        DTOProblemModel Get(int id);
    }
}

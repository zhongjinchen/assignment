using BLL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servise
{
    public interface IProblemService
    {
        Problem Publish(DTOProblemModel dTOProblemModel);
        DTOProblemModel Get(int id);
        IList<Problem> GetAll();

    }
}

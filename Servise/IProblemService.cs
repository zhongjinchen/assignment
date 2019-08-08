using BLL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servise
{
    public interface IProblemService:IService
    {
        Problem Publish(DTOProblemModel dTOProblemModel);
        DTOProblemModel Get(int id);
        IList<Problem> GetAll(int? AuthorId,int pageIndex, int pageSize);
        void Delete(int Id);
    }
}

using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IService<T>
    {
        IResult Add(T t);
        IResult Delete(int id);
        IResult Update(T t);
        IDataResult<List<T>> GetAll();
        IDataResult<List<T>> GetById(int id);
        

        
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IService<T>
    {
        void Add(T t);
        void Delete(int id);
        void Update(int id,T t);
        List<T> GetAll();
        List<T> GetById(int id);
        

        
    }
}

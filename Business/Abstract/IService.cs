using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IService<T>
    {
        void Add(T t);
        List<T> GetAll();
        
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataK
{
    public interface IRepository<T> where T : class
    {
        void Add(T item);
        void Remove(T item);
        void Update(T item);
        T Get(int id);
        List<T> GetAll();
    }
}

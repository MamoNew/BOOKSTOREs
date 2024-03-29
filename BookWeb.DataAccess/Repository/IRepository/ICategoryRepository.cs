﻿using Book.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category> // it should be CategoryController1
    {
        object FirstOrDefault(Func<object, bool> value);
        void Update(Category obj);
        //void Save();
    }
}

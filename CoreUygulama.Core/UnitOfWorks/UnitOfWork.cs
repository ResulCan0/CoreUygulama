﻿using CoreUygulama.Core.Repositeries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreUygulama.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        IProductRepository Products { get; }

        ICategoryRepository Categories { get; }

        Task CommitAsync();

        void Commit();
    }
}

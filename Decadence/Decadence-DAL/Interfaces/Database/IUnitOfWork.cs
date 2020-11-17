using System;
using System.Collections.Generic;
using System.Text;

namespace Decadence_DAL.Interfaces
{
    public interface IUnitOfWork
    {
        //all repos objects
        void Complete();
    }
}

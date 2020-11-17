﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Decadence_DAL.Interfaces
{
    public interface IConnectionFactory
    {
        IDbConnection GetConnection { get; }
        void SetConnection(string connectionString);   
    }
}

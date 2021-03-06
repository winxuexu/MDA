﻿using Orleans;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Grain.interfaces.DeclarativePersistence
{
    public interface IManager : IGrainWithGuidKey
    {
        Task<IEmployee> AsEmployee();
        Task<List<IEmployee>> GetDirectReports();
        Task AddDirectReport(IEmployee employee);
    }
}

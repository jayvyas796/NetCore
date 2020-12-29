﻿using NetCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Interface
{
   public interface IJobService
    {
        int Delete(int JobId);
        Job GetByJobId(int JobId);
        string Update(Job job);
        int Create(Job JobDetails);
        List<Job> ListAll();
    }
}

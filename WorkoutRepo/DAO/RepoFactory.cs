﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutRepo.DAO
{
    public static class RepoFactory
    {
        public static IRepo GetRepo() => new FileRepo();
    }
}

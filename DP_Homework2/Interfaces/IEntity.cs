﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Homework2.Interfaces
{
    public interface IEntity
    {
        int Id { get; set; }
        string Name { get; set; }

        void ShowInfo();
    }
}

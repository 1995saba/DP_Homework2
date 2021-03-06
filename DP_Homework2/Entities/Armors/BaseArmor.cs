﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Homework2.Entities.Armors
{
    public abstract class BaseArmor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public BaseArmor()
        {
            Name = "Armor";
        }
        public virtual void Show() { Console.WriteLine(Name); }
    }
}

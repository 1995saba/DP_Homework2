﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Homework2.Entities.Armors
{
    public class StandardArmor:BaseArmor
    {
        public StandardArmor()
        {
            Name = "Standard Armor";
        }
        public override void Show()
        {
            Console.WriteLine(Name);
        }
    }
}

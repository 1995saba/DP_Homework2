using DP_Homework2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Homework2.Entities.Skills
{
    public abstract class Skill:IEntity
    {
        public int Level { get; set; }
    }
}

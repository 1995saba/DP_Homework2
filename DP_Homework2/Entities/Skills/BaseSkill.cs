using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Homework2.Entities.Skills
{
    public abstract class BaseSkill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }

        public BaseSkill()
        {
            Name = "Base Skill";
        }

        public virtual void Show()
        {
            Console.WriteLine(Name);
        }
    }
}

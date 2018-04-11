using DP_Homework2.Entities.Skills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Homework2.Entities.Heroes
{
    public abstract class BaseCharacter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<BaseSkill> Skills { get; set; }
        public Stock Stock { get; set; }

        public BaseCharacter()
        {
            Name = "Base Hero";
        }
        public virtual void Show()
        {
            Console.WriteLine(Name);
        }
    }
}

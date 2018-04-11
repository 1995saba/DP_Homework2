using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Homework2.Entities.Mobs
{
    public class BaseMob
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public BaseMob()
        {
            Name = "Base Mob";
        }
        public virtual void Show()
        {
            Console.WriteLine(Name);
        }
    }
}

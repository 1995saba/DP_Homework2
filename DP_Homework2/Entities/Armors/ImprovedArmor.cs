using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Homework2.Entities.Armors
{
    public class ImprovedArmor:BaseArmor
    {
        public ImprovedArmor()
        {
            Name = "Improved Armor";
        }
        public override void Show()
        {
            Console.WriteLine(Name);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DP_Homework2.Entities.Heroes;

namespace DP_Homework2.Factories
{
    public class WarriorFactory : IFactory
    {
        public BaseCharacter Create()
        {
            return new Warrior();
        }
    }
}

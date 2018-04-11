using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DP_Homework2.Entities.Heroes;

namespace DP_Homework2.Factories
{
    public class WizardFactory : IFactory
    {
        public BaseCharacter Create()
        {
            return new Wizard();
        }
    }
}

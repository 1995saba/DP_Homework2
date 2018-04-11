using DP_Homework2.Entities.Heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Homework2.Factories
{
    public interface IFactory
    {
        BaseCharacter Create();
    }
}

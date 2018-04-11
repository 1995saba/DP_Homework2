using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Homework2.Entities.Weapons
{
    public abstract class BaseWeapon
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public BaseWeapon()
        {
            Name = "Base Weapon";
        }

        public virtual void Show()
        {
            Console.WriteLine(Name);
        }
    }
}

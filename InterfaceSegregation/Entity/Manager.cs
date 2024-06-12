using InterfaceSegregation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation.Entity
{
    public class Manager : IHiring, IFiring
    {
        public bool FiringAbilities()
        {
            Console.WriteLine("Only i can fire someone");
            return true;
        }

        public bool HiringAbilities()
        {
            Console.WriteLine("Only i can hire someone");
            return true;
        }
    }
}

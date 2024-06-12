using InterfaceSegregation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation.Entity
{
    public class HumanResources : IHiring
    {
        public bool HiringAbilities()
        {
            Console.WriteLine("I can hiring");
            return true;
        }
    }
}

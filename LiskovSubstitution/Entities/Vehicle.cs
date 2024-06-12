using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution.Entities
{
    public class Vehicle
    {
        public virtual bool Move()
        {
            Console.WriteLine("Araçlar yol alır");
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution.Entities
{
    public class Plane:Vehicle
    {
        public override bool Move()
        {
            Console.WriteLine("Ama uçaklar uçar");
            return base.Move();
        }
    }
}

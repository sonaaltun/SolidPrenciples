using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution.Entities
{
    public class Car:Vehicle
    {
        public override bool Move()
        {
            Console.WriteLine("Arabalar karada yürür");

            return base.Move();
        }
    }
}

using SingleResponsibility.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility.Repositories
{
    public interface ICustomerRespository
    {
        bool Add(Customer customer);
    }
}

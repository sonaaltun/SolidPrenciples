using Microsoft.EntityFrameworkCore;
using SingleResponsibility.Base;
using SingleResponsibility.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility.Repositories
{
    public class CustomerRepository : ICustomerRespository
    {
        private readonly DbContext dbContext;

        public CustomerRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public bool Add(Customer customer)
        {
            var newCustomer = dbContext.Add(customer);
            return true;
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.Repository
{
    public class ProductRespository:IProductRepository
    {
        private readonly DbContext _dbContext;

        public ProductRespository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}

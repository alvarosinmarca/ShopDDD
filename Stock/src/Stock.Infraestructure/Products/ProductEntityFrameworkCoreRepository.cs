﻿using SharedKernel.Infrastructure.Data.EntityFrameworkCore.Repositories;
using Stock.Domain.Products;
using Stock.Infrastructure.Data.EFCore;

namespace Stock.Infrastructure.Products
{
    internal class ProductEntityFrameworkCoreRepository : EntityFrameworkCoreRepositoryAsync<Product>, IProductRepository
    {
        public ProductEntityFrameworkCoreRepository(StockDbContext dbContext) : base(dbContext)
        {

        }
    }
}

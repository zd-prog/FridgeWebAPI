﻿using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public IEnumerable<Product> GetAllProducts(bool trackChanges) =>
            FindAll(trackChanges).OrderBy(p => p.Name).ToList();

        public Product GetProduct(Guid productId, bool trackChanges) =>
            FindByCondition(p => p.Id.Equals(productId), trackChanges).SingleOrDefault();
    }
}

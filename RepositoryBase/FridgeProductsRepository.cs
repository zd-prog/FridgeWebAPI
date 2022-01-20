using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class FridgeProductsRepository: RepositoryBase<FridgeProducts>, IFridgeProductsRepository
    {
        public FridgeProductsRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public IEnumerable<FridgeProducts> GetAllFridgeProducts(Guid fridgeId, bool trackChanges) =>
            FindByCondition(p => p.FridgeId.Equals(fridgeId), trackChanges)
            .OrderBy(p => p.Product.Name);
        public FridgeProducts GetFridgeProduct(Guid fridgeId, Guid productId, bool trackChanges) =>
            FindByCondition(fp => fp.FridgeId.Equals(fridgeId) && fp.ProductId.Equals(productId),
                trackChanges).SingleOrDefault();
    }
}

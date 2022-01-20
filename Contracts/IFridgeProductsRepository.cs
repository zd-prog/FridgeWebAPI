using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IFridgeProductsRepository
    {
        IEnumerable<FridgeProducts> GetAllFridgeProducts(Guid fridgeId, bool trackChanges);
        FridgeProducts GetFridgeProduct(Guid fridgeId, Guid productId, bool trackChanges);
        void CreateFridgeProduct(Guid FridgeId, FridgeProducts fridgeProduct);
        void DeleteFridgeProduct(FridgeProducts fridgeProduct);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepositoryManager
    {
        IFridgeRepository Fridge { get; }
        IFridgeProductsRepository FridgeProducts { get; }
        IProductRepository Product { get; }
        IModelRepository Model { get; }
        void Save();
    }
}

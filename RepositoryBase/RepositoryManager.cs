using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private RepositoryContext _repositoryContext;
        private IModelRepository _modelRepository;
        private IProductRepository _productRepository;
        private IFridgeRepository _fridgeRepository;
        private IFridgeProductsRepository _fridgeProductsRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public IModelRepository Model
        {
            get
            {
                if (_modelRepository == null)
                    _modelRepository = new ModelRepository(_repositoryContext);

                return _modelRepository;
            }
        }

        public IFridgeRepository Fridge
        {
            get
            {
                if (_fridgeRepository == null)
                    _fridgeRepository = new FridgeRepository(_repositoryContext);

                return _fridgeRepository;
            }
        }

        public IFridgeProductsRepository FridgeProducts
        {
            get
            {
                if (_fridgeProductsRepository == null)
                    _fridgeProductsRepository = new FridgeProductsRepository(_repositoryContext);

                return _fridgeProductsRepository;
            }
        }

        public IProductRepository Product
        {
            get
            {
                if (_productRepository == null)
                    _productRepository = new ProductRepository(_repositoryContext);

                return _productRepository;
            }
        }

        public void Save() => _repositoryContext.SaveChanges();
    }
}

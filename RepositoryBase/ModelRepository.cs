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
    public class ModelRepository : RepositoryBase<FridgeModel>, IModelRepository
    {
        public ModelRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }

        public IEnumerable<FridgeModel> GetAllModels(bool trackChanges) =>
            FindAll(trackChanges).OrderBy(m => m.Name).ToList();

        public FridgeModel GetModel(Guid modelId, bool trackChanges) =>
            FindByCondition(m => m.Id.Equals(modelId), trackChanges).SingleOrDefault();
    }
}

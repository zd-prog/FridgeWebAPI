using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IModelRepository
    {
        IEnumerable<FridgeModel> GetAllModels(bool trackChanges);
        FridgeModel GetModel(Guid modelId, bool trackChanges);
        void CreateModel(FridgeModel model);
    }
}

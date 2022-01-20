using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FridgeWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelsController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ModelsController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetModels()
        {
                var models = _repository.Model.GetAllModels(trackChanges: false);

                var modelsDto = _mapper.Map<IEnumerable<ModelDto>>(models);

                return Ok(modelsDto);
        }

        [HttpGet("{id}")]
        public IActionResult GetModel(Guid id)
        {
            var model = _repository.Model.GetModel(id, trackChanges: false);
            if (model == null)
            {
                _logger.LogInfo($"Model with id: {id} doesn's exist in the database.");
                return NotFound();
            }
            else
            {
                var modelDto = _mapper.Map<ModelDto>(model);
                return Ok(modelDto);
            }
        }
    }
}

using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;
using Entities.Models;
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

        [HttpGet("{id}", Name = "ModelById")]
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

        [HttpPost]
        public IActionResult CreateModel([FromBody]ModelForCreationDto model)
        {
            if (model == null)
            {
                _logger.LogError("ModelForCreationDto object sent from client is null.");
                return BadRequest("ModelForCreationDto object is null");
            }

            var modelEntity = _mapper.Map<FridgeModel>(model);

            _repository.Model.CreateModel(modelEntity);
            _repository.Save();

            var modelToReturn = _mapper.Map<ModelDto>(modelEntity);

            return CreatedAtRoute("ModelById", new { id = modelToReturn.Id }, modelToReturn);
        }
    }
}

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
    [Route("api/fridges/{fridgeid}/products")]
    [ApiController]
    public class FridgeProductsController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public FridgeProductsController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetFridgeProducts(Guid fridgeId)
        {
            var fridge = _repository.Fridge.GetFridge(fridgeId, trackChanges: false);
            if (fridge == null)
            {
                _logger.LogInfo($"Fridge with id: {fridgeId} doesn't exist in the database.");
                return NotFound();
            }

            var productsFromDb = _repository.FridgeProducts.GetAllFridgeProducts(fridgeId, 
                trackChanges: false);

            var productsDto = _mapper.Map<IEnumerable<FridgeProductDto>>(productsFromDb);
            
            return Ok(productsDto);
        }

        [HttpGet("{id}", Name = "GetProductForFridge")]
        public IActionResult GetFridgeProduct(Guid fridgeId, Guid id)
        {
            var fridge = _repository.Fridge.GetFridge(fridgeId, trackChanges: false);
            if (fridge == null)
            {
                _logger.LogInfo($"Fridge with id: {fridgeId} doesn't exist in the database.");
            return NotFound();
            }
            var productDb = _repository.FridgeProducts.GetFridgeProduct(fridgeId, id, 
                trackChanges: false);
            if (productDb == null)
            {
                _logger.LogInfo($"Product with id: {id} doesn't exist in the database.");
                return NotFound();
            }
            var product = _mapper.Map<FridgeProductDto>(productDb);
            return Ok(product);
        }

        [HttpPost]
        public IActionResult CreateProductForFridge(Guid fridgeId, [FromBody]
        FridgeProductForCreationDto product)
        {
            if (product == null)
            {
                _logger.LogError("FridgeProductForCreationDto object sent from client is null.");
                return BadRequest("FridgeProductForCreationDto object is null");
            }

            var fridge = _repository.Fridge.GetFridge(fridgeId, trackChanges: false);
            if (fridge == null)
            {
                _logger.LogInfo($"Fridge with id: {fridgeId} doesn't exist in the database.");
                return NotFound();
            }

            var productEntity = _mapper.Map<FridgeProducts>(product);

            _repository.FridgeProducts.CreateFridgeProduct(fridgeId, productEntity);
            _repository.Save();

            var productToReturn = _mapper.Map<FridgeProductDto>(productEntity);

            return CreatedAtRoute("GetProductForFridge", new { fridgeId, id = productToReturn.Id },
                productToReturn);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProductForFridge(Guid fridgeId, Guid id)
        {
            var fridge = _repository.Fridge.GetFridge(fridgeId, trackChanges: false);
            if (fridge == null)
            {
                _logger.LogInfo($"Fridge with id: {fridgeId} doesn't exist in the database.");
                return NotFound();
            }

            var productForFridge = _repository.FridgeProducts.GetFridgeProduct(fridgeId, id,
                trackChanges: false);
            if (productForFridge == null)
            {
                _logger.LogInfo($"Product with id: {id} doesn't exist in the database.");
                return NotFound();
            }

            _repository.FridgeProducts.DeleteFridgeProduct(productForFridge);
            _repository.Save();

            return NoContent();
        }
    }
}

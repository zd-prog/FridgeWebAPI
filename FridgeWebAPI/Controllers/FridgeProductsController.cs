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
        public IActionResult GetFridgeProducts()
        {
            try
            {
                var fridgeProducts = _repository.FridgeProducts
                    .GetAllFridgeProducts(trackChanges: false);

                var fridgeProductsDto = _mapper.Map<IEnumerable<FridgeProductDto>>(fridgeProducts);

                return Ok(fridgeProductsDto);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetFridgeProducts)} " +
                    $"action {ex}");

                return StatusCode(500, "Internal server error");
            }
        }
    }
}

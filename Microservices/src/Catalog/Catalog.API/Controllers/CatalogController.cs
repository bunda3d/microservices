using Catalog.API.Entities;
using Catalog.API.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Catalog.API.Controllers
{
	[Route("api/v1/[controller]")]
	[ApiController]
	public class CatalogController : ControllerBase
	{
		//create repository object by getting it from the constructor via dependency injection (registered in startup.cs
		private readonly IProductRepository _repository;
		private readonly ILogger<CatalogController> _logger;

		public CatalogController(IProductRepository repository, ILogger<CatalogController> logger) : this(repository)
		{
			_logger = logger ?? throw new ArgumentNullException(nameof(logger));
		}

		public CatalogController(IProductRepository repository)
		{
			_repository = repository ?? throw new ArgumentNullException(nameof(repository));
		}

		[HttpGet] //returning action result and so return status
		[ProducesResponseType(typeof(IEnumerable<Product>), (int)HttpStatusCode.OK)]
		public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
		{
			var products = await _repository.GetProducts();
			//Ok = 200 result
			return Ok(products); 
		}


		[HttpGet] //returning action result and so return status or msg
		[ProducesResponseType((int)HttpStatusCode.NotFound)]
		[ProducesResponseType(typeof(Product), (int)HttpStatusCode.OK)]
		public async Task<ActionResult<Product>> GetProductById(string id) //mongo stores as object w/ string id type (not int).
		{
			var product = await _repository.GetProduct(id);
			if (product == null)
			{
				_logger.LogError($"Product with id: {id} not found.");
				return NotFound();
			}
			//Ok = 200 result
			return Ok(product);
		}

		[Route("[action]/{category}")]
		[HttpGet] //returning action result and so return status
		[ProducesResponseType(typeof(IEnumerable<Product>), (int)HttpStatusCode.OK)]
		public async Task<ActionResult<IEnumerable<Product>>> GetProductByCategory(string categoryName)
		{
			var products = await _repository.GetProductByCategory(categoryName);
			//Ok = 200 result
			return Ok(products);
		}

		[HttpPost] //returning action result and so return status or msg
		[ProducesResponseType(typeof(Product), (int)HttpStatusCode.OK)]
		public async Task<ActionResult<Product>> CreateProduct([FromBody] Product product) //expecting prod creation details from body, in JSON format.
		{
			await _repository.Create(product);
			
			//response
			return CreatedAtRoute("GetProduct", new { id = product.Id	}, product);
		}
	}
}

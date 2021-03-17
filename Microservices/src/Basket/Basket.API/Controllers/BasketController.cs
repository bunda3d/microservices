using Basket.API.Repositories.Interfaces;
using Basket.API.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Basket.API.Controllers
{
	[Route("api/vi/[controller]")]
	[ApiController]
	public class BasketController : ControllerBase
	{
		private readonly IBasketRepository _repository;

		public BasketController(IBasketRepository repository)
		{
			_repository = repository ?? throw new ArgumentNullException(nameof(repository));
		}

		[HttpGet]
		[ProducesResponseType(typeof(BasketCart), (int)HttpStatusCode.OK)]
		public async Task<ActionResult<BasketCart>> GetBasket(string userName)
		{
			var basket = await _repository.GetBasket(userName);
			//null check for empty cart, if so => return new empty cart in user's name
			return Ok(basket ?? new BasketCart(userName));
		}

		[HttpPost]
		[ProducesResponseType(typeof(BasketCart), (int)HttpStatusCode.OK)]
		public async Task<ActionResult<BasketCart>> UpdateBasket([FromBody] BasketCart basket)
		{
			return Ok(await _repository.UpdateBasket(basket));
		}

		[HttpDelete("{userName}")]
		[ProducesResponseType(typeof(BasketCart), (int)HttpStatusCode.OK)]
		public async Task<ActionResult> DeleteBasket(string userName)
		{
			return Ok(await _repository.DeleteBasket(userName));
		}

	}
}

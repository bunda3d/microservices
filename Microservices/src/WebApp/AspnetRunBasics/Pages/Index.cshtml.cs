using AspnetRunBasics.ApiCollection.Interfaces;
using AspnetRunBasics.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspnetRunBasics.Pages
{
	public class IndexModel : PageModel
	{
		private readonly IBasketApi _basketApi;
		private readonly ICatalogApi _catalogApi;

		public IndexModel(IBasketApi basketApi, ICatalogApi catalogApi)
		{
			_basketApi = basketApi ?? throw new ArgumentNullException(nameof(basketApi));
			_catalogApi = catalogApi ?? throw new ArgumentNullException(nameof(catalogApi));
		}

		public IEnumerable<CatalogModel> ProductList { get; set; } = new List<CatalogModel>();

		public async Task<IActionResult> OnGetAsync()
		{
			ProductList = await _catalogApi.GetCatalog();
			return Page();
		}

		public async Task<IActionResult> OnPostAddToCartAsync(string productId)
		{
			//if (!User.Identity.IsAuthenticated)
			//    return RedirectToPage("./Account/Login", new { area = "Identity" });

			var product = await _catalogApi.GetCatalog(productId);

			var userName = "Yolo";
			var basket = await _basketApi.GetBasket(userName);

			basket.Items.Add(new BasketItemModel
			{
				ProductId = productId,
				ProductName = product.Name,
				Price = product.Price,
				Quantity = 1,
				Color = "Black"
			});

			var basketUpdated = await _basketApi.UpdateBasket(basket);
			return RedirectToPage("Cart");
		}
	}
}
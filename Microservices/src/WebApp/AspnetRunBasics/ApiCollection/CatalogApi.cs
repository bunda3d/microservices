using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

using AspnetRunBasics.ApiCollection.Infrastructure;
using AspnetRunBasics.ApiCollection.Interfaces;
using AspnetRunBasics.ApiCollection.Settings;
using AspnetRunBasics.Models;

namespace AspnetRunBasics.ApiCollection
{
	public class CatalogApi : BaseHttpClientWithFactory, ICatalogApi
	{
		private readonly IApiSettings _settings;

		public CatalogApi(IHttpClientFactory factory, IApiSettings settings) : base(factory)
		{
			_settings = settings
		}

		public async Task<IEnumerable<CatalogModel>> GetCatalog()
		{
			// base address is api gateway (port: 7000)
			var message = new HttpRequestBuilder(_settings.BaseAddress)
				.SetPath(_settings.CatalogPath)
				.HttpMethod(HttpMethod.Get)
				.GetHttpMessage();

			return await SendRequest<IEnumerable<CatalogModel>>(message);
		}

		public async Task<CatalogModel> GetCatalog(string id)
		{
			throw new NotImplementedException();
		}

		public async Task<CatalogModel> GetCatalog(CatalogModel model)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<CatalogModel>> GetCatalogByCategory(string category)
		{
			throw new NotImplementedException();
		}
	}
}
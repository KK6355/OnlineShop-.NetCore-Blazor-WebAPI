﻿namespace BlazorEcommerce.Server.Services.ProductService
{
	public interface IProductService
	{
		Task<ServiceResponse<List<Product>>> GetProductsAsync();
		Task<ServiceResponse<Product>> GetProductAsync(int productId);
        Task<ServiceResponse<List<Product>>> GetProductsByCategoryAsync(string categoryUrl);
		Task<ServiceResponse<ProductsSearchResult>> SearchProducts(string searchText, int page);
		Task<ServiceResponse<List<string>>> GetProductSearchSuggestion(string searchText);
		Task<ServiceResponse<List<Product>>> GetFeaturedProducts();
	}
}


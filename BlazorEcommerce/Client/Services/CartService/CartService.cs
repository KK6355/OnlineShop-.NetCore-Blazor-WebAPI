
using Blazored.LocalStorage;
using System.Net.Http.Json;

namespace BlazorEcommerce.Client.Services.CartService
{
	public class CartService : ICartService
	{
		private readonly ILocalStorageService _localStorage;
		private readonly HttpClient _httpClient;

		public CartService(ILocalStorageService localStorageService, HttpClient httpClient)
        {

            _localStorage = localStorageService;
			_httpClient = httpClient;
        }
        public event Action OnChange;

		public async Task AddToCart(CartItem cartItem)
		{
			var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
			if (cart == null)
			{
				cart = new List<CartItem>();
			}
			cart.Add(cartItem);
			await _localStorage.SetItemAsync("cart", cart);
			OnChange.Invoke();
		}

		public async Task<List<CartItem>> GetCartItems()
		{
			var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
			if (cart == null)
			{
				cart = new List<CartItem>();
			}
			return cart;
		}

		public async Task<List<CartProductResponse>> GetCartProducts()
		{
			var cartItems = await _localStorage.GetItemAsync<List<CartItem>>("cart");
			var response = await _httpClient.PostAsJsonAsync("api/cart/products", cartItems);
			var cartProduct = await response.Content.ReadFromJsonAsync<ServiceResponse<List<CartProductResponse>>>();
			return cartProduct.Data;
		}
	}
}

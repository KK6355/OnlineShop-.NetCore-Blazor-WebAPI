using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorEcommerce.Shared
{
	public class ProductsSearchResult
	{
		public List<Product> Products { get; set; } = new List<Product>();
		public int Pages { set; get; }
		public int CurrentPage {  set; get; } 
	}
}

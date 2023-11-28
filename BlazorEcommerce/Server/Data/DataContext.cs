namespace BlazorEcommerce.Server.Data
{
	public class DataContext:DbContext
	{
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
            

        }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Product>().HasData(
				new Product
				{
					Id = 1,
					Title = "The Hitchhiker's Guide to the Galaxy",
					Description = "The Hitchhiker's Guide to the Galaxy is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including novels, stage shows, comic books, a 1981 TV series, a 1984 text adventure game, and 2005 feature film.",
					ImageURL = "https://images.unsplash.com/photo-1614926037384-4159c33e196b?q=80&w=1892&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
					Price = 9.99m
				},
				new Product
				{
					Id = 2,
					Title = "Ready Player One",
					Description = "The Hitchhiker's Guide to the Galaxy is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including novels, stage shows, comic books, a 1981 TV series, a 1984 text adventure game, and 2005 feature film.",
					ImageURL = "https://images.unsplash.com/photo-1614926037384-4159c33e196b?q=80&w=1892&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
					Price = 7.99m
				},
				new Product
				{
					Id = 3,
					Title = "Nineteen Eighty-Four",
					Description = "The Hitchhiker's Guide to the Galaxy is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including novels, stage shows, comic books, a 1981 TV series, a 1984 text adventure game, and 2005 feature film.",
					ImageURL = "https://images.unsplash.com/photo-1614926037384-4159c33e196b?q=80&w=1892&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
					Price = 6.99m
				}
				);
		}
		public DbSet<Product> Products { get; set; }
    }
}

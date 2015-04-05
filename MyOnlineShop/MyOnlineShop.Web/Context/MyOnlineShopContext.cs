using System.Data.Entity;
using MyOnlineShop.Web.Context.Entity;

namespace MyOnlineShop.Web.Context
{
	public class MyOnlineShopContext : DbContext
	{
		public MyOnlineShopContext() : base("Database")
		{
		}

		public DbSet<Category> Categories { get; set; }

		public DbSet<Good> Goods { get; set; }
	}
}
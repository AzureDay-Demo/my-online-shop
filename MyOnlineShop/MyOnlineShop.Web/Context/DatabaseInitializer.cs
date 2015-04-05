using System.Data.Entity;
using MyOnlineShop.Web.Context.Entity;

namespace MyOnlineShop.Web.Context
{
	public class DatabaseInitializer : CreateDatabaseIfNotExists<MyOnlineShopContext>
	{
		protected override void Seed(MyOnlineShopContext context)
		{
			var category1 = new Category { Title = "Fruits" };
			var category2 = new Category { Title = "Vegetables" };

			var good11 = new Good { Category = category1, Title = "Apple" };
			var good12 = new Good { Category = category1, Title = "Pear" };
			var good13 = new Good { Category = category1, Title = "Cherry" };

			var good21 = new Good { Category = category2, Title = "Potato" };
			var good22 = new Good { Category = category2, Title = "Onion" };

			context.Categories.Add(category1);
			context.Categories.Add(category2);

			context.Goods.Add(good11);
			context.Goods.Add(good12);
			context.Goods.Add(good13);
			context.Goods.Add(good21);
			context.Goods.Add(good22);

			context.SaveChanges();

			base.Seed(context);
		}
	}
}
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyOnlineShop.Web.Context.Entity
{
	public class Category
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string Title { get; set; }

		public virtual List<Good> Goods { get; set; }
	}
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyOnlineShop.Web.Context.Entity
{
	public class Good
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string Title { get; set; }

		[Required]
		public int CategoryId { get; set; }

		[ForeignKey("CategoryId")]
		public virtual Category Category { get; set; }
	}
}
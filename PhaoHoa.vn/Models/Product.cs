using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace PhaoHoaGaet.vn.Models
{
	[Table("Product")]
	public class Product
	{
		[Key]
		public int ProductID { get; set; }

		[StringLength(100)]
		[Required(ErrorMessage = "Tên sản phẩm không được để trống")]
		[Column(TypeName = "nvarchar(200)")]
		public string ProductName { get; set; }

		[Required(ErrorMessage = "Số lượng không được để trống")]
		public int? Quantity { get; set; }

		public string Image { get; set; }

		[Required(ErrorMessage = "Giá không được để trống")]
		public float? Price { get; set; }

		public float SalePrice { get; set; }


		public ICollection<OrdersDetails> OrderDetails;
	}
}
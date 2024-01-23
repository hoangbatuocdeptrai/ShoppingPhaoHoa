using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PhaoHoaGaet.vn.Models
{
	[Table("Login")]
	public class Login
	{
		[Key]
		[Required(ErrorMessage = "Tài Khoản không được để trống")]
		public string user_name { get; set; }

		[Required(ErrorMessage = "Mật khẩu không được để trống")]
		public string password { get; set; }
    }
}
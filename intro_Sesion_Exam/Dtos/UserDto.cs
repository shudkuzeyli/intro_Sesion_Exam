using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace intro_Sesion_Exam.Dtos
{
	public class UserDto
	{
		[DisplayName("Kullanıcı Adı")]
		[Required]
		[StringLength(20)]
		public string UserName { get; set; }

		[DisplayName("Şifre")]
		[Required]
		[StringLength(8)]

		public string Password { get; set; }

		[DisplayName("Beni Hatırla")]
		public bool RememberMe { get; set; }
	}
}

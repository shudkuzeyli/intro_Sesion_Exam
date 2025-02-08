using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace intro_Sesion_Exam.Models
{
	public class UserModel
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[DisplayName("Ad")]
		[Required]
		[StringLength(20)]
		public string Name { get; set; }

		[DisplayName("Soyad")]
		[Required]
		[StringLength(20)]
		public string Surname { get; set; }

		[DisplayName("Kullanıcı Adı")]
		[Required]
		[StringLength(20)]
		public string UserName { get; set; }

		[DisplayName("Şifre")]
		[Required]
		[StringLength(8)]

		public string Password { get; set; }

	}
}

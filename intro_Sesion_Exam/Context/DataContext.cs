using intro_Sesion_Exam.Models;
using Microsoft.EntityFrameworkCore;

namespace intro_Sesion_Exam.Context
{
	public class DataContext : DbContext
	{

		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{

		}


		public DbSet <UserModel> UserModel { get; set; }
	}
}

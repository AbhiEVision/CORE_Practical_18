using Microsoft.EntityFrameworkCore;
using Practical_18_API.Models;

namespace Practical_18_API.Data
{
	public class DatabaseContextClass : DbContext
	{
		public DatabaseContextClass(DbContextOptions<DatabaseContextClass> options) : base(options)
		{

		}

		public DbSet<Student> students { get; set; }

	}
}

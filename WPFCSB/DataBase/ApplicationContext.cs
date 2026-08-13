using Microsoft.EntityFrameworkCore;
using WPFCSB.Models;

namespace WPFCSB.DataBase
{
	public class ApplicationContext: DbContext
	{
		public DbSet<Person> Persons { get; set; } = null!;
		public DbSet<Manager> Managers { get; set; } = null!;
		public DbSet<Guest> Guests { get; set; } = null!;
		public DbSet<Sanatorium> Sanatoriums { get; set; } = null!;
		public DbSet<BookingOperation> BookingOperations { get; set; } = null!;
		public DbSet<TemplateMessage> TemplateMessages { get; set; } = null!;
		public DbSet<TextTemplateVariable> TextTemplateVariables { get; set; } = null!;

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite("Data Source=databasecsb.db");
		}
	}
}

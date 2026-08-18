using Microsoft.EntityFrameworkCore;
using WPFCSB.DataBase.ModelConfigurations;
using WPFCSB.Models;

namespace WPFCSB.DataBase
{
	public class ApplicationContext: DbContext
	{
		public ApplicationContext()
		{
		// Для тестирования создания базы данных. Перед миграцией закомментировать!
			Database.EnsureDeleted();
			Database.EnsureCreated();
		}

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

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new PersonConfiguration());
			modelBuilder.ApplyConfiguration(new ManagerConfiguration());
			modelBuilder.ApplyConfiguration(new GuestConfiguration());
			modelBuilder.ApplyConfiguration(new SanatoriumConfiguration());
			modelBuilder.ApplyConfiguration(new BookingOperationConfiguration());
			modelBuilder.ApplyConfiguration(new TemplateMessageConfiguration());
			modelBuilder.ApplyConfiguration(new TextTemplateVariableConfiguration());
		}
	}
}

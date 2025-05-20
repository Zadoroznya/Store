using Microsoft.EntityFrameworkCore;
using Store.Core.Models;

namespace Store.Core.Database;

public class AppDbContext : DbContext {
	public DbSet<Literature> LiteratureItems => Set<Literature>();
	public DbSet<Purchase> Purchases => Set<Purchase>();

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
		optionsBuilder.UseSqlite("Data Source=Store.db");
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder) {
		modelBuilder.Entity<Literature>()
		            .HasDiscriminator<string>("LiteratureType")
		            .HasValue<Book>("Book")
		            .HasValue<Magazine>("Magazine");

		modelBuilder.Entity<Purchase>()
		            .HasOne(p => p.Literature)
		            .WithMany()
		            .HasForeignKey(p => p.LiteratureId);

		base.OnModelCreating(modelBuilder);
	}

	/// <summary>
	///     Ініціалізація бази даних
	/// </summary>
	/// <returns>Статус ініціалізації</returns>
	internal async Task<bool> CreateDatabase() =>
		await Database.EnsureCreatedAsync();
}
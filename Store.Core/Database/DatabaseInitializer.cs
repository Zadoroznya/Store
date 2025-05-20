using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

namespace Store.Core.Database;

public static class DatabaseInitializer {
	public static void Initialize(this AppDbContext db) {
		if (db.Database.GetService<IDatabaseCreator>() is not RelationalDatabaseCreator databaseCreator)
			return;

		if (!databaseCreator.ExistsAsync()
		                    .GetAwaiter()
		                    .GetResult())
			db.CreateDatabase()
			  .GetAwaiter()
			  .GetResult();

		if (!databaseCreator.HasTables())
			db.CreateDatabase()
			  .GetAwaiter()
			  .GetResult();
	}
}
using Microsoft.EntityFrameworkCore;

public class MyDbContext : DbContext
{
	public DbSet<Message> Messages { get; set; }

	public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
	{
	    Database.EnsureCreated();
		Database.Migrate();
	}

	// christopher : "Server=tcp:sqlservermessagerie.database.windows.net,1433;Initial Catalog=messagerie;Persist Security Info=False;User ID=christopher;Password=Rose230323;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
	// didinet : "Server=tcp:sqlserverbookstore.database.windows.net,1433;Initial Catalog=bookstore;Persist Security Info=False;User ID=didinet;Password=azure23-23;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlServer("Server=tcp:sqlserverbookstore.database.windows.net,1433;Initial Catalog=bookstore;Persist Security Info=False;User ID=didinet;Password=azure23-23;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
	}
}

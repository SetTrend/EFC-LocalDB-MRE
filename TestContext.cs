using Microsoft.EntityFrameworkCore;

namespace EFC_LocalDB_MRE;

internal class TestContext : DbContext
{
	public DbSet<TestEntity> Tests { get; set; }



	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseLazyLoadingProxies().UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Temp\Test.mdf;Integrated Security=True");
}

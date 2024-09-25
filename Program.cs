namespace EFC_LocalDB_MRE;

internal class Program
{
	static void Main(string[] _)
	{
		new TestContext().Database.EnsureDeleted();
	}
}

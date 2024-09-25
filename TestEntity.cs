using System.ComponentModel.DataAnnotations;

namespace EFC_LocalDB_MRE;

public class TestEntity(int id, string text)
{
	public int Id { get; init; } = id;

	[Length(2, 200)]
	public string Text { get; set; } = text;
}

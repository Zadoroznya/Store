using Store.Core.Enums;

namespace Store.Core.Models;

public class Purchase {
	public int Id { get; set; }
	public LiteratureType Type { get; set; }
	public bool IsCredit { get; set; }
	public int LiteratureId { get; set; }
	public Literature Literature { get; set; } = null!;
	public DateTime PurchaseDate { get; set; }
	public string? Buyer { get; set; }
}
using Microsoft.EntityFrameworkCore;
using Store.Core.Enums;

namespace Store.Core.Models;

[PrimaryKey(nameof(Id))]
public abstract class Literature {
	public int Id { get; set; }
	public string? Title { get; set; }
	public string? Topic { get; set; }
	public Languages Language { get; set; }
	public int Pages { get; set; }
	public decimal Price { get; set; }

	public abstract void DisplayInfo();
	public abstract decimal CalculateCost();
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _00_EFTrial;

public class Product
{
    // [Key]
	public int ProductId { get; set; }
	[Required]
	[StringLength(40)]
	public string ProductName { get; set; }
	[Column(TypeName = "money")]
	public int UnitPrice { get; set; }
	[ForeignKey("Category")]
	public int CategoryId { get; set; }
}

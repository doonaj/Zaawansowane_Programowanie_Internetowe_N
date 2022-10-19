using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.Model.DataModel;

public class ProductStock : Product
{

    public virtual Product Product { get; set; } = default!;
    [ForeignKey("Product")]
    public int? ProductId { get; set; }
    public int Quantity { get; set; }
}

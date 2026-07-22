using System.ComponentModel.DataAnnotations;

namespace VakifPayPos.Models;

public class OrderItem
{
    [Key]
    public int orderItemId { get; set; }
    public int orderId { get; set; }
    public int productId { get; set; }
    public int quantity { get; set; }
    public int unitPrice { get; set; }
    public decimal commisionRate { get; set; }
    public DateTime createDate { get; set; } = DateTime.Now;
    public DateTime updateDate { get; set; } = DateTime.Now;

    public Order Order { get; set; } = null!;
    public Pos Pos { get; set; } = null!;
}
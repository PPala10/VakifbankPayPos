using System.ComponentModel.DataAnnotations;

namespace VakifPayPos.Models;

public class Order
{
    [Key]
    public int orderId { get; set; }
    public int customerId { get; set; }
    public int totalAmount { get; set; }
    public string status { get; set; } = "Pending";
    public DateTime createDate { get; set; } = DateTime.Now;
    public DateTime updateDate { get; set; } = DateTime.Now;
    
    public Customer Customer { get; set; } = null!;
    public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    public ICollection<Payment> Payments { get; set; } = new List<Payment>();
}


using System.ComponentModel.DataAnnotations;

namespace VakifPayPos.Models;

public class Pos
{
    [Key]
    public int posID { get; set; }
    public string posName { get; set; }
    public string posType { get; set; } 
    public string priceType { get; set; }
    public int price { get; set; }
    public string description { get; set; } 
    public string valorType { get; set; } 
    public decimal commisionRate { get; set; }
    public bool isPurchase { get; set; }
    public bool isActive { get; set; } = true;
    public DateTime createDate { get; set; } = DateTime.Now;
    public DateTime updateDate { get; set; } = DateTime.Now;

    // Navigation Properties
    public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
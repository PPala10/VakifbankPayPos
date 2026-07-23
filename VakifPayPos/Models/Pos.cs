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
    public string imageUrl { get; set; } = string.Empty;
    public decimal commisionRate { get; set; }
    public bool isPurchase { get; set; }
    public bool isActive { get; set; } = true;
    public DateTime createDate { get; set; } = DateTime.Now;
    public DateTime updateDate { get; set; } = DateTime.Now;

    public string GetDisplayImage()
    {
        var type = posType?.ToLower() ?? "";

        if (type.Contains("mobil"))
        {
            return "/img/mobil-placeholder.svg";
        }
        if (type.Contains("okc"))
        {
            return "/img/okc-placeholder.svg";
        }
        if (type.Contains("vuk") || type.Contains("507"))
        {
            return "/img/vuk507-placeholder.svg";
        }
        if (type.Contains("sabit"))
        {
            return "/img/sabit-placeholder.svg";
        }
        return "/img/sabit-placeholder.svg"; // Default image if no match is found
    }

    // Navigation Properties
    public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
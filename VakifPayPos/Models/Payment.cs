using System.ComponentModel.DataAnnotations;

namespace VakifPayPos.Models;

public class Payment
{
    [Key]
    public int paymentId { get; set; }
    public int orderId { get; set; }
    public string cardNumber { get; set; } 
    public string cardHolderName { get; set; } 
    public string cardExpirationDate { get; set; } 
    public string CVC { get; set; } 
    public string PaymentStatus { get; set; } = "Success";
    public DateTime PaidDate { get; set; } = DateTime.Now;

    // Navigation Properties
    public Order Order { get; set; } = null!;
}
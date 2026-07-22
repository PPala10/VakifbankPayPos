using System.ComponentModel.DataAnnotations;

namespace VakifPayPos.Models;

public class CustomerDocument
{
    [Key]
    public int documentId { get; set; }
    public int customerId { get; set; }
    public string documentType { get; set; }
    public string filePath { get; set; }
    public bool isApproved { get; set; } 
    public DateTime createDate { get; set; } = DateTime.Now;
    public DateTime updateDate { get; set; } = DateTime.Now;

    // Navigation Properties
    public Customer Customer { get; set; }
}
using System.ComponentModel.DataAnnotations;

namespace VakifPayPos.Models;

public class Customer
{
    [Key]
    public int customerID { get; set; }
    public string customerType { get; set; }
    public string companyName { get; set; }
    public string taxNumber { get; set; } 
    public string taxOffice { get; set; } 
    public string managerName { get; set; } 
    public long managerTCKN { get; set; }
    public string phone { get; set; } 
    public string email { get; set; } 
    public string webURL { get; set; }
    public string city { get; set; }
    public string state { get; set; } 
    public string IBAN { get; set; } 
    public string address { get; set; } 
    public decimal longitute { get; set; }
    public decimal latitude { get; set; }
    public string status { get; set; } = "Pending";
    public string businessType { get; set; }
    public string monthlySalary { get; set; }
    public DateTime createDate { get; set; } = DateTime.Now;
    public DateTime updateDate { get; set; } = DateTime.Now;

    // Navigation Properties
    public ICollection<CustomerDocument> CustomerDocuments { get; set; } = new List<CustomerDocument>();
    public ICollection<Order> Orders { get; set; } = new List<Order>();
}
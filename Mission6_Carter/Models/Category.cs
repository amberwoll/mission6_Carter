namespace Mission6_Carter.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Category
{
    [Key]
    [Required]
    public int CategoryId { get; set; }
    [Required]
    public string CategoryName { get; set; }
}
namespace Mission6_Carter.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


public class Movie
{
    [Key]
    [Required]
    public int MovieId { get; set; }

    [ForeignKey("CategoryId")]
    public int? CategoryId { get; set; }
    
    public Category? Category { get; set; }
    
    [Required]
    public string Title { get; set; }
    [Required]
    public int Year { get; set; }

    public string? Director { get; set; }
    public string? Rating { get; set; }
    [Required]
    public bool Edited { get; set; }
    public string? LentTo { get; set; }
    
    [Required]
    public bool CopiedToPlex {get; set;}
    
    public string? Notes { get; set; }

}
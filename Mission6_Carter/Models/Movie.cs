namespace Mission6_Carter.Models;
using System.ComponentModel.DataAnnotations;

public class Movie
{
    [Key]
    [Required]
    public int MovieId { get; set; }
    [Required]
    
    public string Title { get; set; }
    [Required]
    public int Year { get; set; }
    [Required]
    public string Director { get; set; }
    [Required]
    public int Rating { get; set; }
    public bool Edited { get; set; }
    public string LentTo { get; set; }
    [StringLength(25, MinimumLength = 0, ErrorMessage = "Notes can be a maximum of 25 characters.")]
    public string Notes { get; set; }
    
}
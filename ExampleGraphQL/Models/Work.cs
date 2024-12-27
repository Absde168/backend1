using ExampleGraphQL.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class Work
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    public string? Description { get; set; }
    [Required]
    public decimal Cost { get; set; } 
    public DateTime? Date { get; set; }
    [Required]
    public int TeamId { get; set; } 
    public Team? Team { get; set; }
    [Required]
    public bool WorkCompleted { get; set; }
    [Required]
    public int OrderId { get; set; } 
    public Order? Order { get; set; }
    public DateTime? DatePerformed { get; internal set; }
}

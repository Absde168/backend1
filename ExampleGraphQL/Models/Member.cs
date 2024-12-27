using ExampleGraphQL.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class Member
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; } 
    [Required]
    public string Role { get;set; }
    [Required]
    public DateTime? DatePerformed { get; set; }
    [Required]
    public bool WorkCompleted { get; set; }
    [Required]
    public string FullName { get; set; }
    [Required]
    public string PhoneNumber { get; set; }
    [Required]
    public int TeamId { get; set; } 
    public Team? Team { get; set; } 

}

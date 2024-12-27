using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExampleGraphQL.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int ClientId { get; set; } 
        public Client? Client { get; set; } 

        public DateTime? StartDate { get; set; } 
        public DateTime? EndDate { get; set; } 
        [Required]
        public decimal TotalCost { get; set; }
        [Required]
        public bool IsPaid { get; set; }
        [Required]
        public string? Description { get; set; }  
        public DateTime? DatePerformed { get; set; }
        [Required]
        public bool WorkCompleted { get; set; }
            
        public bool IsOverdue { get; set; }
        public ICollection<Work>? Works { get; set; }
    }

}

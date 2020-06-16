using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("MenuItems")]
public class MenuItem
{
    [Key]
    public int ItemId { get; set; } 
    [Required]
    [StringLength(255)]
    public string ItemName { get; set; }
     [Required]
    public string ItemDescription { get; set; }

    [Required]    
    public double Price { get; set; }
    [Required]
     [StringLength(50)]
    public string Type { get; set; }
    [Required]
    [StringLength(50)]
    public string ImageName{get;set;}
}
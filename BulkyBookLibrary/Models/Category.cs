using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyBookLibrary.Models;

public class Category
{
    [Key]
    public int CategoryId { get; set; }
    [Required]
    public string Name { get; set; }
    
    [DisplayName("Display Order")]
    [Range(1,20,ErrorMessage ="Display Order Should be between 1 to 100 !")]
    public int DisplayOrder { get; set; } 

    public DateTime CreatedDate { get; set; } =  DateTime.Now;

}

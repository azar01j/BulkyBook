namespace BulkyBookLibrary.Models;

public class Category
{
    public int CategoryId { get; set; }
    public string Name { get; set; } 
    public int DisplayOrder { get; set; } 

    public DateTime CreatedDate { get; set; } =  DateTime.Now;

}

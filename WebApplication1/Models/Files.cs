using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models;

[Table("Files")]
public class Files
{
    [Key] 
    public long id { get; set; }
    public string Name { get; set; }
    public byte Pdf { get; set; }
    
}
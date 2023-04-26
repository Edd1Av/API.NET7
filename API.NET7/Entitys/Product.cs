using System.ComponentModel.DataAnnotations;

namespace API.NET7.Entitys
{
    public class Product
    {
        public int Id { get; set; }
        
        public required string? Name { get; set; }
        public string? Description { get; set; }
        public int Stock { get; set; }
        public DateTime CreateDate { get; set; }

    }
}

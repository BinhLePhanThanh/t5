namespace MIS.Entity
{
    public class Author
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? Address { get; set; }
        public string? Genre { get; set; }
        public bool? Status { get; set; }
        List<Product>? Products { get; set; }
    }
}

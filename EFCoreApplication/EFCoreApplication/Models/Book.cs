namespace EFCoreApplication.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string ?Title { get; set; }   
        public bool IsIssued { get; set; }
        public virtual Author? Author { get; set; }
    }
}

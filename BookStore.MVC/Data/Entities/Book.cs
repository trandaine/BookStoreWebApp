using System.ComponentModel.DataAnnotations;

namespace BookStore.MVC.Data.Entities
{
    public class Book
    {
        public Book()
        {
            Id = Guid.NewGuid();
            DateCreated = DateTime.Now;
        }
        public Guid Id { get; set; }
        //public Guild BookId { get; set; }
        //[MaxLength(100)]
        public string Title { get; set; }
        public string? Alias { get; set; }
        public string? Description { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid AuthorId { get; set; }
        public Author Author { get; set; }
        public Guid MediaId { get; set; }
        public Media Media { get; set; }
        public Guid CategoryId {  get; set; }
        public Category Category { get; set; }


    }
}

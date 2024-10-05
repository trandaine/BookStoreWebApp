using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace BookStore.MVC.Data.Entities
{
    public class Author
    {
        public Author()
        {
            Books = new Collection<Book>();
        }
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Name { get; set; }
        public DateTime? DateOfBirth { get; set; }
        //[Phone]
        public string Phone { get; set; }
        //[EmailAddress]
        public string Email { get; set; }
        public int Position { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}

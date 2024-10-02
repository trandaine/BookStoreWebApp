using System.Collections.ObjectModel;

namespace BookStore.MVC.Data.Entities
{
    public class Category
    {
        public Category() 
        {
            Books = new Collection<Book>();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public string Description { get; set; }
        public int Position {  get; set; }
        public ICollection<Book> Books { get; set; }

    }
}

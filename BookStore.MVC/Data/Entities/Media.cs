using System.Collections.ObjectModel;

namespace BookStore.MVC.Data.Entities
{
    public class Media
    {
        public Media() 
        {
            Books = new Collection<Book>();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public string FileName { get; set; }
        public string Extension {  get; set; }
        public int Position { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}

namespace my_booksReal.Data.Models
{
    public class Book_Author
    {
        //ovo je klasa Join entity, klasa koja sadrzi samo id-eve
        //knjiga i njihovih autora
        public int Id { get; set; }

        //Navigation property
        public int BookId { get; set; }
        public Book Book { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}

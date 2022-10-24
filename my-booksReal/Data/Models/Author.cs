namespace my_booksReal.Data.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        //Navigation Properties many to many
        //zbog many to many mora da postoji join entity kao sto je book_author
        public List<Book_Author> Book_Authors { get; set; }
        //ovde je lista autora zbog toga sto (u 3.3 kaze da knjiga moze da ima vise autora)
        //postaje many to many relacija i zbog toga je lista.
        //ona predstavlja  listu autora 1 knjige
    }
}

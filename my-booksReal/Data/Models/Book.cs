using System.Data;

namespace my_booksReal.Data.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsRead { get; set; }
        public DateTime? DateRead { get; set; }
        public int? Rate { get; set; }
        public string Genre { get; set; }
        public string CoverUrl { get; set; }
        public DateTime DateAdded { get; set; }

        //Navigation properties

        //znak pitanja je tu zbog toga sto je ovo foreing key i on bi morao da bude
        //popunjen (kolona) da nema ovog znaka (oznacava da je nullable), i da nema
        //znaka ? morao bih da izbrisem sve podatke iz tabele

        public int? PublisherId { get; set; }
        public Publisher Publisher { get; set; }

        //publisher je morao da bude definisan zato sto ovako 
        //.net zna da je publisherId primary key publishera i da je 
        //publisherId foreing key book-a

        public List<Book_Author> Book_Authors { get; set; }
        //zbog many to many relacije jer 1 knjiga moze (u ovom slucaju) da ima vise
        //autora
    }
}

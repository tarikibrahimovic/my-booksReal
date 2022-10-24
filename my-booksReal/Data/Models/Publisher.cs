namespace my_booksReal.Data.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //navigation properties

        //lista je zbog 1 na n veze, 1 publisher moze da ima vise knjiga
        //a 1 knjiga moze da ima samo 1 publishera
        //zato u publishera ide lista Book,
        //a u book ide samo publisherId i/ili publisher name
        public List<Book> Book { get; set; }
    }
}

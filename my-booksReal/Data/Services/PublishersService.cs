using my_booksReal.Data.Models;
using my_booksReal.Data.ViewModel;
using my_booksReal.Exceptions;
using System.Text.RegularExpressions;

namespace my_booksReal.Data.Services
{
    public class PublishersService
    {
        private AppDbContext _context;
        public PublishersService(AppDbContext context)
        {
            _context = context;
        }

        public Publisher AddPublisher(PublisherVM publisher)
        {
            if (StringStartsWithNumber(publisher.Name)) throw new PublisherNameException("Name starts with number");
            var _publisher = new Publisher()
            {
                Name = publisher.Name,
            };
            _context.Publishers.Add(_publisher);
            _context.SaveChanges();
            return _publisher;
        }

        public void DeletePublisherById(int id)
        {
            var _publisher = _context.Publishers.FirstOrDefault(n => n.Id == id);
            if(_publisher != null)
            {
                _context.Publishers.Remove(_publisher);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception($"The publisher with id: {id} does not exist");
            }
        }

        private bool StringStartsWithNumber(string name)
        {
            if(Regex.IsMatch(name, @"^\d"))
            {
                return true;
            }
            else
            {
                return false;
            }
        } 
    }
}

using BookAndAuthorWebAPI.DbConnection;
using BookAndAuthorWebAPI.Model;
using BookAndAuthorWebAPI.Model.DTOs;

namespace BookAndAuthorWebAPI.Services
{
    public class BookService
    {
        private AppDbContext _appDbContext;
        public BookService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        //Create new.
        public void AddBook(BookAndAuthorDBModel book)
        {
            var _bookAndAuthorDBModel = new Book()
            {
                Title = book.Title,
                Description = book.Description,
                IsRead = book.IsRead,
                ReadDate = book.IsRead ? book.ReadDate.Value : null,
                Rate = book.IsRead ? book.Rate.Value : null,
                Genre = book.Genre,
                Author = book.Author,
                CoverURL = book.CoverUrl,
              //  BookAddedDate = book.BookAddedDate,
            };
            _appDbContext.Books.Add(_bookAndAuthorDBModel);
            _appDbContext.SaveChanges();
        }

        //GetAll
        public List<Book> GetAllBooks() => _appDbContext.Books.ToList();

        //Get Book by Is
        public Book GetBookById(int bookId) => _appDbContext.Books.FirstOrDefault(n => n.Id == bookId);

        //Update
        public Book UpdateBookById(int bookId, BookAndAuthorDBModel book)
        {
            var _book = _appDbContext.Books.FirstOrDefault(n => n.Id == bookId);
            if (_book != null)
            {
                _book.Title = book.Title;
                _book.Description = book.Description;
                _book.IsRead = book.IsRead;
                _book.ReadDate = book.IsRead ? book.ReadDate.Value : null;
                _book.Rate = book.IsRead ? book.Rate.Value : null;
                _book.Genre = book.Genre;
                _book.Author = book.Author;
                _book.CoverURL = book.CoverUrl;

                _appDbContext.SaveChanges();
            }
            return _book;
        }

        public void DeleteBook(int bookId)
        {
            var _book = _appDbContext.Books.FirstOrDefault(n => n.Id == bookId);
            if (_book != null)
            {
                _appDbContext.Books.Remove(_book);
                _appDbContext.SaveChanges();
            }
        }
    }
}

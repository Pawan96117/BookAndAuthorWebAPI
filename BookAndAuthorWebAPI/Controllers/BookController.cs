using BookAndAuthorWebAPI.Model.DTOs;
using BookAndAuthorWebAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookAndAuthorWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        public BookService _bookServices;
        public BookController(BookService bookServices)
        {
           _bookServices = bookServices;
        }

        //Add new Books
        [HttpPost("Add_Books")]
        public IActionResult AddBook([FromBody] BookAndAuthorDBModel book)
        {
           _bookServices.AddBook(book);
            return Ok();
        }

        //Get All Books
        [HttpGet("Get_All_Books")]
        public IActionResult GetAllBooks()
        {
            var allBooks =_bookServices.GetAllBooks();
            return Ok(allBooks);
        }

        //Book by Id
        [HttpGet("Get_Book_By_Id")]
        public IActionResult GetBookById(int id)
        {
            var BookById =_bookServices.GetBookById(id);
            return Ok(BookById);
        }

        //Update
        [HttpPut("Update_Book")]
        public IActionResult UpdateBookById(int id, [FromBody] BookAndAuthorDBModel book)
        {
            var updateBook =_bookServices.UpdateBookById(id, book);
            return Ok(updateBook);
        }

        //Delete
        [HttpDelete("Delete_Book")]
        public IActionResult DeleteBook(int id)
        {
           _bookServices.DeleteBook(id);
            return Ok();
        }
    }
}

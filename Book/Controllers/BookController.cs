using System;
using System.Collections.Generic;
using System.Linq;
using BookCatalogs.Dtos;
using BookCatalogs.Models;
using BookCatalogs.Interfaces;
using Microsoft.AspNetCore.Mvc;
using BookCatalogs.Exceptions;
using System.Threading.Tasks;

namespace BookCatalogs.Controllers
{
    [ApiController]
    [Route("book")]
    public class BookController : ControllerBase
    {
        private IBookService _service;

        public BookController(IBookService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllBooks([FromQuery] Guid? guid)
        {
            if (guid == null)
                return Ok(await _service.getAllBooks());
            
            return Ok(await _service.getBookByID(guid.Value));
        }

        //[HttpGet]
        //public ActionResult<GeneralResult> GetBookByID( [FromQuery] Guid? guid)
        //{
        //    if (guid == null)
        //        return BadRequest();

        //    var book = _service.getBookByID(guid.Value);

        //    return Ok(book);
        //}

        [HttpPost]
        public async Task<ActionResult> CreateBook(BookDto book)
        {
            var id = await _service.createBook(book);


            return Created("", id);
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteBook([ FromQuery ] Guid? id)
        {
            if(id == null)
                return BadRequest();

            try
            {
                await _service.deleteBook(id.Value);
            }
            catch (NotFoundException ex)
            {
                return NotFound(ex.Message);
            }

            return NoContent();
        }

        [HttpPut("{id}")]
        public  async Task<ActionResult> UpdateBook(Guid id, BookDto book)
        {
            try
            {
                await _service.updateBook(id, book);
            }
            catch (NotFoundException ex)
            {
                return NotFound(ex.Message);   
            }
            

            return NoContent();
        }
    }
}

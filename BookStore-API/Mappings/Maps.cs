using AutoMapper;
using BookStore_API.Data;
using BookStore_API.DTOs;

namespace BookStore_API.Mappings
{
    public class Maps : Profile
    {
        public Maps()
        {
            CreateMap<Author, AuthorDto>();
            CreateMap<Book, BookDto>();
        }
    }
}

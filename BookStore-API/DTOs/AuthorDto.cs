using System.Collections.Generic;

namespace BookStore_API.DTOs
{
    public class AuthorDto
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Bio { get; set; }

        public virtual ICollection<BookDto> Books { get; set; }
    }
}

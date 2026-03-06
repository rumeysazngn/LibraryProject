using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Dtos
{
    public class BookDto
    {
        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public string BookAuthor { get; set; }
        public int StockTotal { get; set; }
        public int StockAvailable { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? CategoryId { get; set; }  
        public string CategoryName { get; set; } 

    }
}

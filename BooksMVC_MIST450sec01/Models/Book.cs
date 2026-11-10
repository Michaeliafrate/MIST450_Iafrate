using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BooksMVC_MIST450sec01.Models
{
    public class Book
    {

        [Key]
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Published Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime DatePublished { get; set; }
        public string Genre { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal Price { get; set; }
    }
}

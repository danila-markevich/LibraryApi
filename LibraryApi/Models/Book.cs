using System.ComponentModel.DataAnnotations;

namespace LibraryApi.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Название обязательно")]
        [StringLength(200, MinimumLength = 1)]
        public string Title { get; set; } = "";

        [Required(ErrorMessage = "Автор обязателен")]
        [StringLength(100, MinimumLength = 1)]
        public string Author { get; set; } = "";

        [Range(1000, 2100, ErrorMessage = "Год должен быть от 1000 до 2100")]
        public int Year { get; set; }

        [Range(0.01, 100000, ErrorMessage = "Цена должна быть от 0.01 до 100000")]
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
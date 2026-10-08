using System.ComponentModel.DataAnnotations;

namespace LibraryApi.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Название категории обязательно")]
        [StringLength(100, MinimumLength = 1)]
        public string Name { get; set; } = "";

        public List<Book> Books { get; set; } = new();
    }
}
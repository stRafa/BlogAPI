using Blog.Models;
using System.ComponentModel.DataAnnotations;

namespace Blog.ViewModels.Posts
{
    public class CreatePostViewModel
    {
        [Required(ErrorMessage = "O título é obrigatório")]
        [MaxLength(50, ErrorMessage = "O título pode conter no máximo 50 caracteres")]
        [MinLength(3, ErrorMessage = "O título deve conter no mínimo 3 caracteres")]
        public string Title { get; set; }

        [MaxLength(255, ErrorMessage = "O título pode conter no máximo 255 caracteres")]
        [MinLength(3, ErrorMessage = "O título deve conter no mínimo 3 caracteres")]
        public string? Summary { get; set; }

        [Required(ErrorMessage = "O corpo do post é obrigatório")]
        [MaxLength(100000, ErrorMessage = "O título pode conter no máximo 100000 caracteres")]
        [MinLength(3, ErrorMessage = "O título deve conter no mínimo 3 caracteres")]
        public string Body { get; set; }

        [Required(ErrorMessage = "A categoria é obrigatória")]
        public Category Category { get; set; }

        [Required(ErrorMessage = "O autor é obrigatório")]
        public User Author { get; set; }
        public List<Tag>? Tags { get; set; }
    }
}

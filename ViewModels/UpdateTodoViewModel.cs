using System;
using System.ComponentModel.DataAnnotations;

namespace MeuTodo.ViewModels
{
    public class UpdateTodoViewModel
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public bool Done { get; set; }
        public DateTime Date { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace DNP_Assignment_1.Models
{
    public class Todo
    {
        [Required]
        [Range(1,int.MaxValue, ErrorMessage = "Please add a value larger than {1}")]
        public int UserId { get; set; }
        public int TodoId { get; set; }
        [Required, MaxLength(128)]
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
    }
}
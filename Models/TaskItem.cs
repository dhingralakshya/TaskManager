using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace TaskManagerApp.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        
        [Required]
        public string Title { get; set; } = string.Empty;
        
        public string Description { get; set; } = string.Empty;
        
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        
        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }
        
        public bool IsCompleted { get; set; }
        
        public string UserId { get; set; } = string.Empty;
        public IdentityUser? User { get; set; }
        
        [EmailAddress]
        public string AssignedToEmail { get; set; } = string.Empty;
    }
}
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace TaskManagerApp.Models
{
    public class AdminDashboardViewModel
    {
        public List<TaskItem> TaskItems { get; set; } = new List<TaskItem>();
        public List<IdentityUser> Users { get; set; } = new List<IdentityUser>();
    }
}
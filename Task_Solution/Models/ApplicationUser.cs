using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_Solution.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<MyTask> TasksCreated { get; set; }
        public ICollection<MyTask> TasksTargeted { get; set; }
    }
}

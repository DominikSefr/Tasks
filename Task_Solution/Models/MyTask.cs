using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Task_Solution.Models
{
    public class MyTask
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [ForeignKey("FromId")]
        public ApplicationUser From { get; set; }
        public string FromId { get; set; }
        [Required]
        [ForeignKey("ToId")]
        public ApplicationUser To { get; set; }
        public string ToId { get; set; }
        [Required]
        public DateTime Expiration { get; set; }

    }
}

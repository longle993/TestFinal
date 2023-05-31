using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace TestManagement.DTO
{
    public class Question
    {
        [Key]
        [StringLength(20)]
        public string QuestionID { get; set; }

        [Required]
        [StringLength(200)]
        public string QuestionText { get; set; }

        [StringLength(500)]
        public string LoiGiai { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestManagement.DTO
{
    public class Answer
    {
        [Key, Column(Order = 1)]
        [StringLength(20)]
        public string AnswerID { get; set; }

        [Key,Column(Order =2)]
        [StringLength(20)]
        [ForeignKey("Question")]
        public string QuestionID { get; set; }

        [Required]
        [StringLength(200)]
        public string AnswerText { get; set; }
        public bool CorrectAnswer { get; set; }

        public virtual Question Question { get; set; }
    }
}


using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestManagement.DTO
{
    public class TestDetail
    {
        [Key,Column(Order =1)]
        [StringLength(20)]
        public string TestID { get; set; }

        [Key, Column(Order = 2)]
        [StringLength(20)]
        [ForeignKey("Question")]
        public string QuestionID { get; set; }

        public decimal QuestionPoint { get; set; }

        public virtual Test Test { get; set; }
        public virtual Question Question { get; set; }
    }
}


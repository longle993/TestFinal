using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestManagement.DTO
{
    public class Result
    {
        [Key]
        [StringLength(20)]
        public string ResultID { get; set; }

        [ForeignKey("TestTimes")]
        public int TestTimesID { get; set; }

        [Required]
        [StringLength(200)]
        public string StudentName { get; set; }

        [Required]
        [StringLength(30)]
        public string MSSV { get; set; }

        [Required]
        public int NumberCorrect { get; set; }

        [Required]
        public TimeSpan FinishTime { get; set; }

        [Required]
        public decimal Score { get; set; }

        public virtual TestTimes TestTimes { get; set; }
    }
}

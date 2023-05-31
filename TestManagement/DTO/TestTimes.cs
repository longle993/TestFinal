using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestManagement.DTO
{
    public class TestTimes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TestTimesID { get; set; }

        [Required]
        [StringLength(50)]
        public string TestName { get; set; }

        [Required]
        [StringLength(50)]
        public string CodeTest { get; set; }

        [StringLength(20)]
        [ForeignKey("Test")]
        public string TestID { get; set; }

        [Required]
        public DateTime TestDate { get; set; }

        public virtual Test Test { get; set; }
    }
}

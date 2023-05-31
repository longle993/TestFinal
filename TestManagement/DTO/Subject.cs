using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TestManagement.DTO
{
    public class Subject
    {
        [Key]
        [StringLength(20)]
        public string SubjectID { get; set; }

        [Required]
        [StringLength(50)]
        public string SubjectName { get; set; }
        public DateTime InitiationDay { get; set; }
        public DateTime ChangedDay { get; set; }

    }
}

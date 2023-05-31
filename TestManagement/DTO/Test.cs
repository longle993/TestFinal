using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TestManagement.DTO
{
    public class Test
    {
        [Key]
        public string TestID { get; set; }
        public string SubjectID { get; set; }
        public string TestName { get; set; }
        public string Description { get; set; }
        public DateTime InitiationDate { get; set; }
        public DateTime ChangedDate { get; set; }
        public TimeSpan TestTime { get; set; }
    }
}

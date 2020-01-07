using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CURD.Models
{
    public class ProcessGroup
    {

        [Key]
        public int MatchId { get; set; }


        [Required]
        [DisplayName("Process Groups")]
        public string ProcessGrp { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CURD.Models
{
    public class Match
    {
       
            [Key]
            public int MatchId { get; set; }

            
            [Required]
            [DisplayName("Knowledge Area")]
            public string KnowledgeArea { get; set; }
        
      
    }
}

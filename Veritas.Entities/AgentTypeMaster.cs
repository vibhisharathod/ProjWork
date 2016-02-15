using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Veritas.Entities
{
    [Table("AgentTypeMaster")]
    public class AgentTypeMaster
    {
        [Key]
        [Required]
        public int AgentTypeID { get; set; } // int, not null
        [MaxLength(50)]
        public string Name { get; set; } // varchar(50), null
        [MaxLength(50)]
        public string Businesstype { get; set; } // varchar(50), null
        [MaxLength(50)]
        public string Remarks { get; set; } // varchar(50), null
        public bool? Discontinue { get; set; } // bit, null
        public int? CreateUserIndex { get; set; } // int, null
        public DateTime? CreateDateTime { get; set; } // datetime, null
        public int? UpdateUserIndex { get; set; } // int, null
        public DateTime? UpdateDateTime { get; set; } // datetime, null
    }
}

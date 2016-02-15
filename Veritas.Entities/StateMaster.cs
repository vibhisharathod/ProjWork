using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Veritas.Entities
{
    [Table("StateMaster")]
    public class StateMaster
    {
        [Key]
        [Required]
        public int StateIndex { get; set; } // int, not null
        [MaxLength(50)]
        public string StateName { get; set; } // varchar(50), null
        public int? CountryIndex { get; set; } // int, null
        [MaxLength(50)]
        public string Remarks { get; set; } // varchar(50), null
        public bool? Discontinue { get; set; } // bit, null
        public int? CreateUserIndex { get; set; } // int, null
        public DateTime? CreateDateTime { get; set; } // datetime, null
        public int? UpdateUserIndex { get; set; } // int, null
        public DateTime? UpdateDateTime { get; set; } // datetime, null
    }
}

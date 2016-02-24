using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Veritas.Entities
{
    [Table("AreaMaster")]
    public class AreaMaster
    {
        [Key]
        [Required]
        public int AreaIndex { get; set; } // int, not null
        [MaxLength(50)]
        public string AreaName { get; set; } // varchar(50), null
        public int? CityIndex { get; set; } // int, null
        public int? PinCode { get; set; } // int, null
        [MaxLength(50)]
        public string Remarks { get; set; } // varchar(50), null
        public bool? Discontinue { get; set; } // bit, null
        public int? CreateUserIndex { get; set; } // int, null
        public DateTime? CreateDateTime { get; set; } // datetime, null
        public int? UpdateUserIndex { get; set; } // int, null
        public DateTime? UpdateDateTime { get; set; } // datetime, null

        //Adding FK Name property
        public string CityName { get; set; }
    }
}

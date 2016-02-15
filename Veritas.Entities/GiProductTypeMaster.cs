using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Veritas.Entities
{
    [Table("GI_ProductTypeMaster")]
    public class GiProductTypeMaster
    {
        [Key]
        [Required]
        public int GITypeIndex { get; set; } // int, not null
        [MaxLength(100)]
        public string GITypeName { get; set; } // varchar(100), null
        [MaxLength(50)]
        public string Remarks { get; set; } // varchar(50), null
        public bool? Discontinue { get; set; } // bit, null
        public int? CreateUserIndex { get; set; } // int, null
        public DateTime? CreateDateTime { get; set; } // datetime, null
        public int? UpdateUserIndex { get; set; } // int, null
        public DateTime? UpdateDateTime { get; set; } // datetime, null
    }
}

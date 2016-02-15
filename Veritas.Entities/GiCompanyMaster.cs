using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Veritas.Entities
{
    [Table("GI_CompanyMaster")]
    public class GiCompanyMaster
    {
        [Key]
        [Required]
        public int GICompanyIndex { get; set; } // int, not null
        [MaxLength(50)]
        public string GICompanyName { get; set; } // nchar(50), null
        [MaxLength(150)]
        public string Address1 { get; set; } // nchar(150), null
        [MaxLength(150)]
        public string Address2 { get; set; } // nchar(150), null
        [MaxLength(50)]
        public string City { get; set; } // nchar(50), null
        [MaxLength(10)]
        public string PinCode { get; set; } // nchar(10), null
        [MaxLength(15)]
        public string Contact1 { get; set; } // nchar(15), null
        [MaxLength(15)]
        public string Contact2 { get; set; } // nchar(15), null
        [MaxLength(15)]
        public string Fax { get; set; } // nchar(15), null
        [MaxLength(25)]
        public string Email { get; set; } // nchar(25), null
        [MaxLength(25)]
        public string Website { get; set; } // nchar(25), null
        [MaxLength(50)]
        public string Remarks { get; set; } // varchar(50), null
        public int? CreateUserIndex { get; set; } // int, null
        public DateTime? CreateDateTime { get; set; } // datetime, null
        public int? UpdateUserIndex { get; set; } // int, null
        public DateTime? UpdateDateTime { get; set; } // datetime, null
        public bool? Discontinue { get; set; } // bit, null
    }
}

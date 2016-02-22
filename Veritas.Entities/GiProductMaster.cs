using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Veritas.Entities
{
    [Table("GI_ProductMaster")]
    public class GiProductMaster
    {
        [Key]
        [Required]
        public int GIProductIndex { get; set; } // int, not null
        [Display(Name ="Company")]
        public int? GICompanyIndex { get; set; } // int, null
        [Display(Name = "Product Name")]
        [MaxLength(250)]
        public string GIProductName { get; set; } // varchar(250), null

        [Display(Name = "Product Type")]
        public int? GITypeIndex { get; set; } // int, null

        [Display(Name = "Product Start Date")]
        public DateTime? GIProductStartDate { get; set; } // datetime, null
        [Display(Name = "Product End Date")]
        public DateTime? GIProductEndDate { get; set; } // datetime, null
        [MaxLength(50)]
        public string Remarks { get; set; } // varchar(50), null
        public int? CreateUserIndex { get; set; } // int, null
        public DateTime? CreateDateTime { get; set; } // datetime, null
        public int? UpdateUserIndex { get; set; } // int, null
        public DateTime? UpdateDateTime { get; set; } // datetime, null
        public bool? Discontinue { get; set; } // bit, null
    }
}

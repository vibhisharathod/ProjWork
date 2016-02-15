using System;

namespace Veritas.Entities
{
    public class GiInsureMasterViewModel
    {
        public int GIMastIndex { get; set; }
        public string PolicyNo { get; set; }
        public string GICompanyName { get; set; }
        public string Full_NM_LA { get; set; }
        public DateTime? LoginDate { get; set; } 
        public DateTime? PolicyStartDate { get; set; }
    }
}

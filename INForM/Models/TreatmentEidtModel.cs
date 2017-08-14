using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INForM.Models
{
    public class TreatmentEidtModel
    {
        public String TreatID { get; set; }  
        public String TreatmentName { get; set; }
        public String TreatmentDiscription { get; set; }
        public String SupplierName { get; set; }
        public String BillofQty { get; set; }

        public String TreatType { get; set; }
        public String TotalUnit { get; set; }
    }
}
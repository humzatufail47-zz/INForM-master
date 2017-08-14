using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INForM.Models
{
    public class LocationEditModel
    {
        public String LocationId { get; set; }
        public String Campus { get; set; }
        public String Building { get; set; }
        public String Floor { get; set; }
        public String Room { get; set; }
    }
}
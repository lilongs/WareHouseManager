using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Mo_Project
    {
        public string projectNo { get; set; }
        public string projectName { get; set; }
        public string projectHeader { get; set; }
        public DateTime projectStartDate { get; set; }
        public DateTime projectEndDate { get; set; }
        public string projectCompany { get; set; }
        public string projectContact { get; set; }
        public string contactPhone { get; set; }
        public string remark { get; set; }
    }
}
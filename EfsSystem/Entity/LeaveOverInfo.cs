using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EfsSystem.Entity
{
    public class LeaveOverInfo
    {
        public int id { get; set; }
        public string equipName { get; set; }
        public string equipVersion { get; set; }
        public string falutInfo { get; set; }
        public string maintenance { get; set; }
        public string sparePartName { get; set; }
        public string sparePartVersion { get; set; }
        public string sparePartSpecification { get; set; }
        public int sparePartCount { get; set; }
        public int serviceId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EfsSystem.Entity
{
    public class ServiceInfo
    {
        public int id { get; set; }
        public string infoName { get; set; }
        public string receiverName { get; set; }
        public string brief { get; set; }
        public string basicInfo { get; set; }
        public string workOderNumber { get; set; }
        public string unitName { get; set; }
        public string address { get; set; }
        public string responsibleCustomerName { get; set; }
        public string responsibleCustomerTel { get; set; }
        public string responsibleCustomerFax { get; set; }
        public string responsibleUserName { get; set; }
        public string responsibleUserTel { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string userNames { get; set; }
        public string userCount { get; set; }
        public string serviceStyle { get; set; }
        public string equipsCount { get; set; }
        public string faultInfo { get; set; }
        public string returnMoney { get; set; }
        public string explain { get; set; }
        public string satisfiedQuality { get; set; }
        public string satisfiedService { get; set; }
        public string satisfiedDeliver { get; set; }
        public string satisfiedPrice { get; set; }
        public string suggestAppearance { get; set; }
        public string suggestAttitude { get; set; }
        public string suggestPrice { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models
{
    public class ItemReport
    {
        public int Week { get; set; }

        public int Year { get; set; }

        public int Gross { get; set; }

        public int SchedultReceipt { get; set; }

        public int NetRequirement { get; set; }

        public int ProjectOnHand { get; set; }

        public int PlannedOrderReceipt { get; set; }

        public int PlannedOrderRelease { get; set; }
    }
}

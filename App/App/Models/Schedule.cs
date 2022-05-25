using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models
{
    public class Schedule
    {
        public int Id { get; set; }

        public int Week { get; set; }

        public int Year { get; set; }

        public int GrossRequirement { get; set; }

        public int ScheduleReceipt { get; set; }

        public int NetRequiment { get; set; }

        public int ProjectOnHand { get; set; }

        public int PlannedOrderReceipt { get; set; }

        public int PlannedOrderRelease { get; set; }

        public int Demand { get; set; }

        public List<int> Children { get; set; }

    }
}

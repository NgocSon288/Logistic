using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models
{
    public class Schedule
    {
        public List<OrderCus> Orders { get; set; } // order sau khi quy về 1 hệ quy chiếu WA

        public Dictionary<(int,int), int> Inventories { get; set; }

        public ItemCus item { get; set; }      // Inventory của WA

    }
}

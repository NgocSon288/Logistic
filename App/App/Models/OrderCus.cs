using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models
{
    public class OrderCus:Order
    {
        public int ParentId { get; set; }
    }
}

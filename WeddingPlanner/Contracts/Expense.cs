using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingPlanner.Contracts
{
    public class Expense
    {
        public string Item { get; set; }
        public string Amount  { get; set; }
        public string Notes { get; set; }
    }
}

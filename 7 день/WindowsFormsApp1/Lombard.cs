using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public struct Lombard
    {
        public string ClientData { get; set; }
        public string TovarName { get; set; }
        public decimal EvalPrice { get; set; }
        public decimal ZalogSum { get; set; }
        public DateTime DateOfDue { get; set; }
        public int TimeOfSave { get; set; }
    }
}

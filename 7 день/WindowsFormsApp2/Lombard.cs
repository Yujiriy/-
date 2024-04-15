using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    struct Lombard
    {
        public string ClientData;
        public string TovarName;
        public decimal EvalPrice;
        public decimal ZalogSum;
        public DateTime DateOfDue;
        public int TimeOfSave;

        public Lombard(string clientData, string tovarName, decimal evalPrice, decimal zalogSum, DateTime dateOfDue, int timeOfSave)
        {
            ClientData = clientData;
            TovarName = tovarName;
            EvalPrice = evalPrice;
            ZalogSum = zalogSum;
            DateOfDue = dateOfDue;
            TimeOfSave = timeOfSave;
        }
    }
}

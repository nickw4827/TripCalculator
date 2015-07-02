using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripCalculatorFunctions.Entities
{
    public class ExpenseLedgerEntry
    {
        private string _personName = string.Empty;
        private decimal _amount = 0;

        public ExpenseLedgerEntry()
        {
        }

        public ExpenseLedgerEntry(string personName, decimal amount)
        {
            _personName = personName;
            _amount = amount;
        }

        public string PersonName
        {
            get { return _personName; }
            set { _personName = value; }
        }

        public decimal Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

    }
}

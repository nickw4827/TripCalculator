using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripCalculatorFunctions.Entities
{
    public class Person
    {
        private string _personName = string.Empty;
        private List<decimal> _expenses = null;
        private List<KeyValuePair<string, decimal>> _payoutObligations = null;

        /// <summary>
        /// Instantiate a person object
        /// </summary>
        public Person()
        {
            _expenses = new List<decimal>();
            _payoutObligations = new List<KeyValuePair<string, decimal>>();
        }

        public Person(string personName)
        {
            _expenses = new List<decimal>();
            _payoutObligations = new List<KeyValuePair<string, decimal>>();

            _personName = personName;

        }

        /// <summary>
        /// Add an expense amount to this person
        /// </summary>
        /// <param name="expenseAmount">Currency amount of the expense</param>
        public void AddExpense(decimal expenseAmount)
        {
            _expenses.Add(expenseAmount);
        }

        /// <summary>
        /// Add a payout obligation for this person.  
        /// Payout Obligation is an amount owed associated with a person the money is owed to.
        /// </summary>
        /// <param name="payoutObligation">Key value pair of person name and amount owed</param>
        public void AddPayoutObligation(KeyValuePair<string, decimal> payoutObligation)
        {
            _payoutObligations.Add(payoutObligation);
        }

        /// <summary>
        /// Add a payout obligation for this person.
        /// Payout Obligation is an maount owed associated with a person the money is owed to.
        /// </summary>
        /// <param name="personName">Person name money is owed to</param>
        /// <param name="paymentAmount">Amount that is owed.</param>
        public void AddPayoutObligation(string personName, decimal paymentAmount)
        {
            _payoutObligations.Add(new KeyValuePair<string, decimal>(personName, paymentAmount));
        }

        /// <summary>
        /// Person Name property
        /// </summary>
        public string PersonName
        {
            get { return _personName; }
            set { _personName = value; }
        }

        /// <summary>
        /// Expenses property
        /// </summary>
        public List<decimal> Expenses
        {
            get { return _expenses; }
        }

        /// <summary>
        /// Payout Obligations property
        /// </summary>
        public List<KeyValuePair<string, decimal>> PayoutObligations
        {
            get { return _payoutObligations; }
        }

        /// <summary>
        /// Output object as string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Person Name: " + _personName);
            foreach (double expense in _expenses)
            {
                sb.AppendLine("Expense: " + expense.ToString());
            }
            foreach (KeyValuePair<string, decimal> kvp in _payoutObligations)
            {
                sb.AppendLine("Payout Obligation: " + kvp.Value.ToString() + " to " + kvp.Key);
            }

            return sb.ToString();

        }

    }
}

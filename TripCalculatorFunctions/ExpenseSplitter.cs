using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripCalculatorFunctions
{
    public class ExpenseSplitter
    {

        /// <summary>
        /// Calculates expense split for persons in the sorted list, and populates the payout list in each person object
        /// </summary>
        /// <param name="persons">Sorted list of persons to split expenses for</param>
        /// <returns></returns>
        public static void SplitExpenses(SortedList<string, Entities.Person> persons)
        {
            //return if there is no data
            if (persons.Count == 0) return;

            //add up expenses 
            List<Entities.ExpenseLedgerEntry> expenseLedger = BuildExpenseLedger(persons);
            decimal totalExpenses = expenseLedger.Sum(o => o.Amount);
            decimal averageExpenses = totalExpenses / persons.Count;

            Console.WriteLine("Total Expenses is: " + totalExpenses.ToString());
            Console.WriteLine("Average Expenses is: " + averageExpenses.ToString());

            //sort the ledger by amount
            expenseLedger = expenseLedger.OrderBy(o => o.Amount).ToList();

            /* If ledger amount is less than the average expense, person owes money, is a "debtor". 
             * If ledger amount is more than the average expense, person is owed money, is a "creditor".
             * try to pay largest debtor to largest creditor 
             * keep iterating until all debt is gone 
             */
            
            //create reverse iterator for creditor (largest creditor first)
            int j = expenseLedger.Count - 1;

            //iterate expense ledger for debtors (largest debtor first)
            for (int i = 0; i < expenseLedger.Count; i++)
            {
                //exit loop when first creditor is reached
                if (expenseLedger[i].Amount >= averageExpenses)
                    break;

                //calculate amount debtor owes
                decimal debtorAmountOwes = averageExpenses - expenseLedger[i].Amount;

                //iterate creditors until debt is paid off
                while (debtorAmountOwes > 0)
                {
                    decimal payout = 0;
                    
                    //calculate amount creditor lent
                    decimal creditorAmountLent = expenseLedger[j].Amount - averageExpenses;
                    if (creditorAmountLent > 0)
                    {
                        //calculate payout amount to this creditor
                        if (debtorAmountOwes >= creditorAmountLent) payout = creditorAmountLent;  //make a debt payment to pay off this creditor
                        else payout = debtorAmountOwes; //make a debt payment to clear all obligations

                        //post payment to creditor
                        Entities.Person debtor = persons[expenseLedger[i].PersonName];
                        debtor.AddPayoutObligation(expenseLedger[j].PersonName, payout);
                        
                        //reduce the debtor amount owed by payout amount
                        debtorAmountOwes -= payout;
                        //reduce this creditors balance by payout amount
                        expenseLedger[j].Amount -= payout;

                    }
                    else
                    {
                        //creditor is paid off, move to next creditor
                        j--;
                    }

                    //debt didn't get all posted to creditors before we ran out of creditors
                    if (j < i) throw new Exception("Error posting debt to creditors; there are no additional creditors to post debt to");

                } //~iterate creditors

            } //~iterate expense ledger

        }

     
        /// <summary>
        /// Create an expense ledger of person and amount of expenses
        /// </summary>
        /// <param name="persons"></param>
        /// <returns></returns>
        private static List<Entities.ExpenseLedgerEntry> BuildExpenseLedger(SortedList<string, Entities.Person> persons)
        {
            List<Entities.ExpenseLedgerEntry> expenseLedger = new List<Entities.ExpenseLedgerEntry>();
            
            //iterate each person and their expenses
            foreach (KeyValuePair<string, Entities.Person> kvp in persons)
            {
                decimal workingExpenses = 0;
                foreach (decimal expense in kvp.Value.Expenses)
                {
                    workingExpenses += expense;
                }
                //add total of expenses for this person to ledger
                expenseLedger.Add(new Entities.ExpenseLedgerEntry(kvp.Key, workingExpenses));
            }

            return expenseLedger;

        }

    }
}

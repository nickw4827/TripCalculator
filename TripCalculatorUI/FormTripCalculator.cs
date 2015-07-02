using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TripCalculatorUI
{
    public partial class FormTripCalculator : Form
    {

        List<List<Decimal>> _expenses = new List<List<decimal>>();
        List<List<String>> _payouts = new List<List<string>>();

        public FormTripCalculator()
        {
            InitializeComponent();
        }

        private void btnAddTripMember_Click(object sender, EventArgs e)
        {
            //create a new expense list for this person
            _expenses.Add(new List<Decimal>());

            //GUI work
            lstTripMembers.Items.Add(txtTripMember.Text);
            txtTripMember.Text = string.Empty;
            txtTripMember.Focus();

        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            //add expense for this person
            _expenses[lstTripMembers.SelectedIndex].Add(Convert.ToDecimal(txtExpense.Text));

            //GUI work
            lstExpenses.Items.Add(txtExpense.Text);
            txtExpense.Text = string.Empty;
            txtExpense.Focus();
        }

        private void lstTripMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //exit if not valid selection
            if (lstTripMembers.SelectedIndex<0) return;

            //GUI work
            btnAddExpense.Enabled = true;
            lstExpenses.Items.Clear();

            //show expenses for this person
            foreach (Decimal amount in _expenses[lstTripMembers.SelectedIndex])
            {
                lstExpenses.Items.Add(amount.ToString());
            }

            //if payouts calculated, show payouts for this person 
            if (_payouts.Count > lstTripMembers.SelectedIndex)
            {
                lstPayouts.Items.Clear();
                foreach (String payout in _payouts[lstTripMembers.SelectedIndex])
                {
                    //GUI work
                    lstPayouts.Items.Add(payout);
                }

            }

        }

        private void btnCalculatePayouts_Click(object sender, EventArgs e)
        {

            SortedList<string, TripCalculatorFunctions.Entities.Person> persons = new SortedList<string, TripCalculatorFunctions.Entities.Person>();
            
            //populate sorted list with persons/expenses
            int ix = 0;
           
            foreach (string pName in lstTripMembers.Items)
            {
                TripCalculatorFunctions.Entities.Person p = new TripCalculatorFunctions.Entities.Person(pName);
                foreach (Decimal amount in _expenses[ix])
                {
                    p.AddExpense(amount);
                }
                persons.Add(pName, p);            
                ix++;
            }

            //calculate payouts
            TripCalculatorFunctions.ExpenseSplitter.SplitExpenses(persons);

            //GUI work
            lstTripMembers.SelectedIndex = -1;
            lstPayouts.Items.Clear();
            //lstPayouts.Items.Add("Click on a team member to see payouts");

            //populate payout results
            //for each trip member
            foreach (string pName in lstTripMembers.Items)
            {
                //add each payout obligation for this trip member
                //create a list
                List<string> payoutObligationList = new List<string>();
                foreach (KeyValuePair<string, Decimal> kvp in persons[pName].PayoutObligations)
                {
                    String str = pName + " owes to " + kvp.Key + ": " + kvp.Value.ToString("F"); // ("#.##");
                    payoutObligationList.Add(str);

                    //GUI
                    lstPayouts.Items.Add(str);
                }
                //add entry if there is no money owed (person is a creditor)
                if (persons[pName].PayoutObligations.Count == 0)
                {
                    String str = pName + " does not owe any money";
                    payoutObligationList.Add(str);

                    //GUI
                    lstPayouts.Items.Add(str);
                }

                //add the obligations list to the trip member payouts list
                _payouts.Add(payoutObligationList);
            }



        }

        private void FormTripCalculator_Load(object sender, EventArgs e)
        {
            //GUI work
            lstExpenses.Items.Add("Click on a team member to add expenses");
        }
    }
}

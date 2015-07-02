using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TripCalculatorFunctions;
using TripCalculatorFunctions.Entities;

namespace TripCalculatorTests.UnitTests
{
    class PersonUnitTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [TearDown]
        public void TearDown()
        {

        }

        [Test]
        public void Test_Person_INSTANTIATE_PersonName()
        {
            Person person = new Person("Test Name");

            Assert.AreEqual("Test Name", person.PersonName);

        }

        [Test]
        public void Test_Person_AddExpense()
        {
            Person person = new Person("Test Name");
            person.AddExpense(10.25m);

            Assert.AreEqual(10.25m, person.Expenses[0]);
        }

        [Test]
        public void Test_Person_AddPayoutObligation_KVP()
        {
            Person person = new Person("Test Name");
            person.AddPayoutObligation(new KeyValuePair<string, decimal>("Test creditor", 23.45m));

            Assert.AreEqual("Test creditor", person.PayoutObligations[0].Key);
            Assert.AreEqual(23.45m, person.PayoutObligations[0].Value);

        }

        [Test]
        public void Test_Person_AddPayoutObligation()
        {
            Person person = new Person("Test Name");
            person.AddPayoutObligation("Test creditor", 23.45m);

            Assert.AreEqual("Test creditor", person.PayoutObligations[0].Key);
            Assert.AreEqual(23.45m, person.PayoutObligations[0].Value);
        }

        [Test]
        public void Test_Person_PROP_PersonName()
        {
            Person person = new Person();

            person.PersonName = "Test Person";
            Assert.AreEqual("Test Person", person.PersonName);
        }

        [Test]
        public void Test_Person_PROP_Expenses()
        {
            Person person = new Person("Test Name");

            Assert.AreEqual(0, person.Expenses.Count);

            person.AddExpense(10.25m);

            Assert.AreEqual(1, person.Expenses.Count);
            Assert.AreEqual(10.25m, person.Expenses[0]);
        }

        [Test]
        public void Test_Person_PROP_PayoutObligations()
        {

            Person person = new Person("Test Name");

            Assert.AreEqual(0, person.PayoutObligations.Count);

            person.AddPayoutObligation("Test creditor", 23.45m);

            Assert.AreEqual(1, person.PayoutObligations.Count);
            Assert.AreEqual("Test creditor", person.PayoutObligations[0].Key);
            Assert.AreEqual(23.45m, person.PayoutObligations[0].Value);
     
        }

        [Test]
        public void Test_Person_ToString()
        {
            Person person = new Person("Test Name");
            person.AddExpense(10.25m);
            person.AddPayoutObligation("Test creditor", 23.45m);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Person Name: Test Name");
            sb.AppendLine("Expense: 10.25");
            sb.AppendLine("Payout Obligation: 23.45 to Test creditor");

            Assert.AreEqual(sb.ToString(), person.ToString());
        }


    }
}

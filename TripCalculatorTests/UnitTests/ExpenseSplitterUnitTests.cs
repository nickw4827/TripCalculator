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
    class ExpenseSplitterUnitTests
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
        public void Test_ExpenseSplitter_NoParties()
        {
            SortedList<string, Person> persons = new SortedList<string, Person>();
        
            ExpenseSplitter.SplitExpenses(persons);

            //there should be nothing happening, and no exceptions
        }

        [Test]
        public void Test_ExpenseSplitter_OneParty()
        {

            //there is no debt to redistribute

            Person p1 = new Person("John Debtor");
            p1.AddExpense(9m);
            p1.AddExpense(1m);

            SortedList<string, Person> persons = new SortedList<string, Person>();
            persons.Add(p1.PersonName, p1);

            Assert.AreEqual(0, p1.PayoutObligations.Count);

        }

        [Test]
        public void Test_ExpenseSplitter_TwoParties()
        {
            Person p1 = new Person("Sally Debtor");
            Person p2 = new Person("Mark Creditor");

            //sally is the debtor
            p1.AddExpense(10m);
            p1.AddExpense(10m);

            //mark is the creditor
            p2.AddExpense(30m);


            SortedList<string, Person> persons = new SortedList<string, Person>();
            persons.Add(p1.PersonName, p1);
            persons.Add(p2.PersonName, p2);

            ExpenseSplitter.SplitExpenses(persons);

            Assert.AreEqual(1, p1.PayoutObligations.Count);
            Assert.AreEqual("Mark Creditor", p1.PayoutObligations[0].Key);
            Assert.AreEqual(5m, p1.PayoutObligations[0].Value);

            Assert.AreEqual(0, p2.PayoutObligations.Count);

        }

        [Test]
        public void Test_ExpenseSplitter_FiveParties()
        {
            Person p1 = new Person("John Debtor");
            Person p2 = new Person("Sally Debtor");
            Person p3 = new Person("Mark Creditor");
            Person p4 = new Person("Brock Debtor");
            Person p5 = new Person("Kane Creditor");

            //john owes the most and will pay mark, the biggest creditor
            p1.AddExpense(9m);
            p1.AddExpense(1m);

            //sally doesn't owe anything
            p2.AddExpense(10m);
            p2.AddExpense(10m);

            //mark is the biggest creditor
            p3.AddExpense(30m);

            //Brock owes the second-most and will pay Kane, the second creditor
            p4.AddExpense(10m);
            p4.AddExpense(5.5m);

            //Kane is the second biggest creditor
            p5.AddExpense(8m);
            p5.AddExpense(14.5m);
            p5.AddExpense(2m);

            SortedList<string, Person> persons = new SortedList<string, Person>();
            persons.Add(p1.PersonName, p1);
            persons.Add(p2.PersonName, p2);
            persons.Add(p3.PersonName, p3);
            persons.Add(p4.PersonName, p4);
            persons.Add(p5.PersonName, p5);

            ExpenseSplitter.SplitExpenses(persons);

            Assert.AreEqual(1, p1.PayoutObligations.Count);
            Assert.AreEqual("Mark Creditor", p1.PayoutObligations[0].Key);
            Assert.AreEqual(10m, p1.PayoutObligations[0].Value);

            Assert.AreEqual(0, p2.PayoutObligations.Count);

            Assert.AreEqual(0, p3.PayoutObligations.Count);

            Assert.AreEqual(1, p4.PayoutObligations.Count);
            Assert.AreEqual("Kane Creditor", p4.PayoutObligations[0].Key);
            Assert.AreEqual(4.5m, p4.PayoutObligations[0].Value);

            Assert.AreEqual(0, p5.PayoutObligations.Count);

        }

    }
}

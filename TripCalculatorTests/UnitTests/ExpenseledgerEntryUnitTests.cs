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
    class ExpenseLedgerEntryUnitTests
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
        public void Test_ExpenseLedgerEntry_INSTANTIATE_PersonName_Amount()
        {
            ExpenseLedgerEntry entry = new ExpenseLedgerEntry("Test Name", 12.34m);

            Assert.AreEqual("Test Name", entry.PersonName);
            Assert.AreEqual(12.34m, entry.Amount);

        }

        [Test]
        public void Test_ExpenseLedgerEntry_PROP_PersonName()
        {
            ExpenseLedgerEntry entry = new ExpenseLedgerEntry();

            entry.PersonName = "Test Name";
            Assert.AreEqual("Test Name", entry.PersonName);

        }

        [Test]
        public void Test_ExpenseLedgerEntry_PROP_Amount()
        {
            ExpenseLedgerEntry entry = new ExpenseLedgerEntry();

            entry.Amount = 12.34m;
            Assert.AreEqual(12.34m, entry.Amount);

        }
    }
}

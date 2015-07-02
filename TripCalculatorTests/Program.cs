using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripCalculatorFunctions;
using TripCalculatorFunctions.Entities;

namespace TripCalculatorTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Test1();
            Test2();
            Test0();
            
        }

        static void Test0()
        {
            Console.WriteLine("*** Test 0 ***");
            Console.WriteLine();

            Person p1 = new Person("Louis");
            Person p2 = new Person("Carter");
            Person p3 = new Person("David");

            p1.AddExpense(5.75m);
            p1.AddExpense(35m);
            p1.AddExpense(12.79m);

            p2.AddExpense(12m);
            p2.AddExpense(15m);
            p2.AddExpense(23.23m);

            p3.AddExpense(10m);
            p3.AddExpense(20m);
            p3.AddExpense(38.41m);
            p3.AddExpense(45m);

            SortedList<string, Person> persons = new SortedList<string, Person>();
            persons.Add(p1.PersonName, p1);
            persons.Add(p2.PersonName, p2);
            persons.Add(p3.PersonName, p3);

            ExpenseSplitter.SplitExpenses(persons);

            Console.WriteLine();

            Console.WriteLine(p1.ToString());
            Console.WriteLine();

            Console.WriteLine(p2.ToString());
            Console.WriteLine();

            Console.WriteLine(p3.ToString());
            Console.WriteLine();

        }

        static void Test1()
        {
            Console.WriteLine("*** Test 1 ***");
            Console.WriteLine();

            Person p1 = new Person("John Debtor");
            Person p2 = new Person("Sally Debtor");
            Person p3 = new Person("Mark Creditor");
            Person p4 = new Person("Brock Debtor");
            Person p5 = new Person("Kane Creditor");

            p1.AddExpense(9m);
            p1.AddExpense(1m);

            p2.AddExpense(10m);
            p2.AddExpense(15m);

            p3.AddExpense(150m);

            p4.AddExpense(22.5m);
            p4.AddExpense(22.5m);

            p5.AddExpense(20m);
            p5.AddExpense(40m);
            p5.AddExpense(20m);

            SortedList<string, Person> persons = new SortedList<string, Person>();
            persons.Add(p1.PersonName, p1);
            persons.Add(p2.PersonName, p2);
            persons.Add(p3.PersonName, p3);
            persons.Add(p4.PersonName, p4);
            persons.Add(p5.PersonName, p5);

            ExpenseSplitter.SplitExpenses(persons);

            Console.WriteLine();

            Console.WriteLine(p1.ToString());
            Console.WriteLine();

            Console.WriteLine(p2.ToString());
            Console.WriteLine();

            Console.WriteLine(p3.ToString());
            Console.WriteLine();

            Console.WriteLine(p4.ToString());
            Console.WriteLine();

            Console.WriteLine(p5.ToString());
            Console.WriteLine();

        }

        static void Test2()
        {
            Console.WriteLine("*** Test 2 ***");
            Console.WriteLine();

            Person p1 = new Person("John Debtor");
            Person p2 = new Person("Sally Debtor");
            Person p3 = new Person("Mark Creditor");
            Person p4 = new Person("Brock Debtor");
            Person p5 = new Person("Kane Creditor");

            p1.AddExpense(9m);
            p1.AddExpense(1m);

            p2.AddExpense(10m);
            p2.AddExpense(10m);

            p3.AddExpense(30m);

            p4.AddExpense(10m);
            p4.AddExpense(5.5m);

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

            Console.WriteLine();

            Console.WriteLine(p1.ToString());
            Console.WriteLine();

            Console.WriteLine(p2.ToString());
            Console.WriteLine();

            Console.WriteLine(p3.ToString());
            Console.WriteLine();

            Console.WriteLine(p4.ToString());
            Console.WriteLine();

            Console.WriteLine(p5.ToString());
            Console.WriteLine();
        }

    }
}

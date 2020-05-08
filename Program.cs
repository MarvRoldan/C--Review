using System;
using System.Linq;
using System.IO; // This allows us to read from files.

namespace C__Review
{
    class Program
    {
        static void mySimpleMethod()
        {
            Console.WriteLine("My simple method has executed!");
        }
        static void myParamMethod(string firstName, string lastName)
        {
            Console.WriteLine("Hello " + firstName + " " + lastName);
        }
        static int myOverloadMethod(int x, int y)
        {
            return x + y;
        }
        static double myOverloadMethod(double x, double y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {

            /*
            * Datatypes
            */
            int number = 2147483647;
            long longnumber = 2313213213214598317;
            // float decimalnumber
            // double longdecimalnumber
            // decimal verylongdecimalnumber

            char myChar = 'H'; // One character. Single qoutes for char.
            string myString = "Hello!"; // One character or string of characters.

            bool myTruthy = true || false;

            /*
            * Operations
            */
            // Arithmetic
            int n = 2;
            int i = 3;

            int addResult = i + n;
            int subtractResult = i - n;
            int multiplicationResult = i * n;
            int divisionResult = i / n;
            int modulusResult = i % n;
            int incrementResult = n++;
            int decrementResult = n--;

            /*
            * Comparison
            */
            Console.WriteLine(i > n);
            Console.WriteLine(i < n);
            Console.WriteLine(i >= n);
            Console.WriteLine(i <= n);
            Console.WriteLine(i == n);
            Console.WriteLine(i != n);

            /*
            * Logical
            */
            Console.WriteLine(i > n && i > 0); // True
            Console.WriteLine(i > n || i > 0); // True
            Console.WriteLine(!true); // False

            /*
            * User Inputs
            */
            Console.WriteLine("Please Type Your Name: ");
            string myName = Console.ReadLine();
            Console.WriteLine("Hello, " + myName);

            /*
            * Math Method
            */
            Console.WriteLine(Math.Max(2, 3));
            Console.WriteLine(Math.Min(2, 3));
            Console.WriteLine(Math.Sqrt(81));
            Console.WriteLine(Math.Abs(-5));
            Console.WriteLine(Math.Round(3.14));

            /*
            * String Methods
            */
            string myStringTwo = "Hello there.";
            Console.WriteLine(myStringTwo.Length);
            Console.WriteLine(myStringTwo.ToUpper());
            Console.WriteLine(myStringTwo.ToLower());

            string[] myStringArray = myStringTwo.Split(" ");
            foreach (string element in myStringArray)
            {
                Console.WriteLine(element);
            }

            string Greeter = $"\"{myString} {myName}\"";
            Console.WriteLine(Greeter);

            /*
            * If / Else / Else if
            */
            string season = "Spring";

            if (season == "Fall")
            {
                Console.WriteLine("It's fall, leaves everywhere!");
            }
            else if (season == "Winter")
            {
                Console.WriteLine("It's winter, show everywhere!");
            }
            else if (season == "Spring")
            {
                Console.WriteLine("It's spring, rain everywhere!");
            }
            else
            {
                Console.WriteLine("It's summer, bugs everywhere!");
            }

            switch (season)
            {
                case "Fall":
                    Console.WriteLine("It's fall, leaves everywhere!");
                    break;
                case "Winter":
                    Console.WriteLine("It's winter, snow everywhere!");
                    break;
                case "Summer":
                    Console.WriteLine("It's summer, bugs everywhere!");
                    break;
                default:
                    Console.WriteLine("No such season.");
                    break;
            }

            /*
            * While / Do While Loop
            */
            int counter = 0;

            while (counter < 3)
            {
                counter++;
                Console.WriteLine(counter);
            }

            counter = 0;

            do // This will run at least once.
            {
                counter++;
                Console.WriteLine(counter);
            } while (counter < 3);

            /*
            * For / Foreach Loops
            */

            int[] myArray = { 1, 2, 3, 4 };

            for (int pos = 0; pos < myArray.Length; pos += 2)
            {
                myArray[pos] = myArray[pos] * 2;
            }

            foreach (int element in myArray)
            {
                Console.WriteLine(element);
            }

            string[] myShoppingList = { "Apple", "Orange", "Banana", "Apple" };
            for (int pos = 0; pos < myShoppingList.Length; pos++)
            {
                if (myShoppingList[pos] == "Apple")
                {
                    myShoppingList[pos] = "Grapes";
                }

            }
            foreach (string element in myShoppingList)
            {
                Console.WriteLine(element);
            }

            /*
            * Array Methods
            */
            string[] myNames = { "John", "Joe", "Bob" };
            Array.Sort(myNames);

            foreach (string element in myNames)
            {
                Console.WriteLine(element);
            }

            /*
            * NEW keyword
            */
            int[] myNumbers;
            myNumbers = new int[] { 1, 2, 3 };

            foreach (int element in myNumbers)
            {
                Console.WriteLine(element);
            }

            /*
            * Ling Array Methods. This was introduced one line 2.
            */
            Console.WriteLine(myNumbers.Min()); // 1
            Console.WriteLine(myNumbers.Max()); // 3
            Console.WriteLine(myNumbers.Sum()); // 6

            /*
            * Methods
            */
            mySimpleMethod();
            myParamMethod("John", "Smith");

            myOverloadMethod(1, 2);
            myOverloadMethod(3.14, 3.14);
            myOverloadMethod(3, 4.32); // Will treat 3 as 3.00.

            /*
            * Files
            */
            string myFile = "example.txt"; // Checks if the file exists.
            if (File.Exists(myFile))
            {
                string myText = File.ReadAllText(myFile);
                Console.WriteLine(myText);
            }
            else
            {
                Console.WriteLine("File does not exist!");
            }

            File.WriteAllText("nextexample.txt", "Hello again, world!"); // Prints out, and then deletes.
            string myTextTwo = File.ReadAllText("example.txt");
            Console.WriteLine(myTextTwo);
            File.Delete("example.txt");
            File.AppendText("And again!"); // This will add to the file text. 
        }
    }
}

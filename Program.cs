﻿using System;

namespace C__Review
{
    class Program
    {
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
            Console.WriteLine(Math.Max(2,3));
            Console.WriteLine(Math.Min(2,3));
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
            foreach (string element in myStringArray) {
                Console.WriteLine(element);
            }

            string Greeter = $"\"{myString} {myName}\"";
            Console.WriteLine(Greeter);

        }
    }
}

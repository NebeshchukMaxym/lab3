using System;
using System.Collections.Generic;
using System.Linq;

namespace Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = new Random().Next(5, 16);
            string[] strings = new string[size];

            for (int i = 0; i < strings.Length; i++)
                strings[i] = GenerateRandomString();

            foreach (string str in strings)
                Console.WriteLine(str);

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine(strings.Aggregate("", (result, str) => result + str.First()));
        }

        static string GenerateRandomString()
        {
            Random random = new Random();
            int size = random.Next(5, 21);

            char[] arr = new char[size];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = (char)random.Next(97, 123);
            return new string(arr);
        }
    }
}

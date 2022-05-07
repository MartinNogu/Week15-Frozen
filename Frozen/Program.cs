using System;
using System.Collections.Generic;
using System.IO;

namespace Frozen
{
    class Program
    {
        class Frozen
        {
            string name;
            string gift;

            public Frozen(string _name, string _gift)
            {
                name = _name;
                gift = _gift;
            }

            public string Name
            {
                get { return name; }
            }

            public string Gift
            {
                get { return gift; }
            }
        }
        static void Main(string[] args)
        {
            List<Frozen> myFrozen = new List<Frozen>();
            string[] giftsFromFile = GetDataFromFile();

            foreach (string line in giftsFromFile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                Frozen newFrozen = new Frozen(tempArray[0], tempArray[1]);
                myFrozen.Add(newFrozen);
            }

            foreach (Frozen frozenFromList in myFrozen)
            {
                Console.WriteLine($"{frozenFromList.Name} wants {frozenFromList.Gift} for Christmas.");
            }
        }

        public static void DisplayElementsFromArray(string[] someArray)
        {
            foreach (string element in someArray)
            {
                Console.WriteLine($"String from array: {element}");
            }
        }

        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\Priit\source\samples\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }
    }
}

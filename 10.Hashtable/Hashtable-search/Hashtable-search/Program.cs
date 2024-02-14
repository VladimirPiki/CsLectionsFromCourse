﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Hashtable_search
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a Hashtable 
            Hashtable myTable = new Hashtable();

            // Adding elements in Hashtable 
            myTable.Add("g", "geeks");
            myTable.Add("c", "c++");
            myTable.Add("d", "data structures");
            myTable.Add("q", "quiz");

            // check if the HashTable contains 
            // the required key or not. 
            if (myTable.ContainsKey("c"))
                Console.WriteLine("myTable contains the key");
            else
                Console.WriteLine("myTable doesn't contain the key");
        }
    }
}
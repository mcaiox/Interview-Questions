using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace HashTable
{
    class Program
    {
        static Hashtable userInfoHash;
        static void Main(string[] args)
        {


            //Console.WriteLine("Hello World!");
            userInfoHash = new Hashtable();
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();


            //Adding
            for (int i = 0; i < 10; i++)
            {
                userInfoHash.Add(i, "user" + i);
                myDictionary.Add(i, "user" + i);
            }

            //Removing
            if (userInfoHash.ContainsKey(0))
            {
                userInfoHash.Remove(0);
            }

            //Setting 
            if (userInfoHash.ContainsKey(1))
            {
                userInfoHash[1] = "Chin";
            }

            //Looping

            foreach (DictionaryEntry entry in userInfoHash)
            {
                Console.WriteLine("Key: " + entry.Key + " => Value: " + entry.Value);
            }

            foreach (KeyValuePair<int, string> element in myDictionary)
            {
                Console.WriteLine("Key:- {0} and Value:- {1}",
                                  element.Key, element.Value);
            }


        }
    }
}

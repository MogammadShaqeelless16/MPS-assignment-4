using System;
using System.Collections.Generic;
using System.Text;
//contains interfaces and classes that define generic collections, which allow users to create strongly typed collections that provide better type safety and performance than non-generic strongly typed collections.8

public static class Words
//created the class words
    {                                                       //hello world
        public static string CountCharactersInSentence(string inputString)

        {
            Dictionary<char, int> Newstring = new Dictionary<char, int>();
            string nothing = inputString;
            foreach (char characters in nothing.Replace(" ", string.Empty))
            {
                if (Newstring.ContainsKey(characters))
                {
                    Newstring[characters] = Newstring[characters] + 1;
                }
                else
                {
                    Newstring.Add(characters, 1);
                }
            }
            foreach (var item in Newstring.Keys)
            {
                nothing += " " + item + " -> " + Newstring[item]+ " ";
            }
            return nothing;
            
        }
            

    }

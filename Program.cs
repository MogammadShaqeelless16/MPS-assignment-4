using System;
//using system means you gonna use application out side of the vscode or vs2019
using System.Text;
//using characters fetch libaries 
using System.Collections.Generic;

//contains interfaces and classes that define generic collections, which allow users to create strongly typed collections that provide better type safety and performance than non-generic strongly typed collections.8


namespace mps_assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // words refer to a class   
                                                                 //string value 
            string charCounts = Words.CountCharactersInSentence("Hello world");
            // create a string  
            // string contain letter text or characters 
            // string name is charcounts  
            // words is a class 
            Console.WriteLine(charCounts);
            //calling out the string charcounts 
            /*

            this is lesson with shaqeel 
            */
        }
    }
}

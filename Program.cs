using System.Collections.Generic;

namespace Variables_Exercise_01
{
    class Program
    {

        
        static void Main(string[] args)
        {
            // - Complete all of the TODO's for this exercise
            // - Once finished save, commit, and then push to GitHub!

            // TODO: Declare 3 constansts

            #region Types
            // string   

            const string name_String = "my_Name";
            System.Console.WriteLine("My string varible && is const #1: " + name_String);
            // char
            char[] my_CharArray = name_String.ToCharArray();
            string alphabet = new string(my_CharArray);
            System.Console.WriteLine("My char[] varible is: " + alphabet);
            // bool
            const bool my_Bool = false;
            System.Console.WriteLine("My bool varible && is const #2: " + my_Bool);
            // int
            const int my_Int = 1969;
            System.Console.WriteLine("My int varible && is const #3: " + my_Int);
            // double
            double my_Double = 5.5;
            System.Console.WriteLine("My double varible is: " + my_Double);
            // decimal
            decimal my_Decimal = 19.69M;
            System.Console.WriteLine("My Decimal varible is: " + my_Decimal);
            #endregion



            // TODO: Declare a variable for each of the types above
            // Make sure to use C# naming convention best practices 

            // TODO: Initialize each of the variables with a value

            // TODO: Write out each of the variables to the Console 
        }

    }
}

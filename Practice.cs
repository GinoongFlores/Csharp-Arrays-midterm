using System.Collections;

namespace Arrays
{
    public class Practice
    {
        public static void Main(string[] args)
        {

            // int[] numbers = new int[10];
            // numbers[0] = 5;
            // numbers[1] = 10;
            // Console.WriteLine(numbers[0] + numbers[1]);

            // One dimensional Array 
            // String[] names = new String[6]; 
            // names[0] = "Jason"; 

            // Accessing an element from array
            /*
            double[] grades = { 98, 99, 100, 95, 96 };
            double studentGrade = grades[0]; */

            // Processing elements of array
            /*
            Console.WriteLine(studentGrade);
            foreach (double grade in grades)
            {
                Console.WriteLine(grade);
            } */


            // Initialize an array upon declaration
            int[,] table = new int[2, 4];
            table[0, 1] = 18;
            table[1, 3] = 4;
            // Accessing an element from the arry
            Console.WriteLine(table[0, 1]);
            Console.WriteLine(table[1, 3]);


            // 2nd Array with 3 rows and 2 columns
            int[,] numbers = new int[3, 2] { { 2, 4 }, { 12, 5 }, { 10, 9 } };
            foreach (int i in numbers)
            {
                Console.WriteLine("{0}", i);
            }

            // ArrayList Syntax
            ArrayList nameOfList = new ArrayList();

            // Adding a value to the Arraylist
            nameOfList.Add("Christian Paul");
            nameOfList.Add("Paul Christian");
            nameOfList.Add("Christian Paul Flores");
            Console.WriteLine(nameOfList[2]);

        }
    }
}
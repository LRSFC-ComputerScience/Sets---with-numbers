using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sets___with_numbers
{
    internal class Program
    {
        public static void DisplaySet(HashSet<int> set)
        {
            Console.Write("{");
            foreach (int value in set)
            {
                Console.Write(" {0} ", value);
            }
            Console.WriteLine(" }");
        }

        static void Main(string[] args)
        {

            Console.WriteLine("My Multi-Dimensional Array");

            String[] my1DArray = new String[] { "Apples", "Pears", "Banana" };

            String[,] my2DArray = new String[3, 2] { { "Apples", "£2.99" }, { "Pears", "£1.99" }, { "Banana", "£3.99" } };

            Console.WriteLine(my1DArray[1]);
            // OUTPUT: "Pears"

            Console.WriteLine(my2DArray[1, 1]);
            // OUTPUT: "PEARS £1.99"

            // declare and initialise each set
            HashSet<int> set_a = new HashSet<int>() { 1 , 2, 3 };
            HashSet<int> set_b = new HashSet<int>() { 2 , 3 , 4 , 5 };

            // display the set_a set
            Console.WriteLine("SET - 'set_a' set contains {0} integer(s): ", set_a.Count);
            DisplaySet(set_a);

            // display the set_b set
            Console.WriteLine("\nSET - 'set_b' set contains {0} integer(s): ", set_b.Count);
            DisplaySet(set_b);

            // ---------------------------------------------------------

            // Create a new empty HashSet for all values
            HashSet<int> allValues = new HashSet<int>(set_a);

            // perform a UNION operation with set_b set
            allValues.UnionWith(set_b);

            // display the union
            Console.WriteLine("\nUNION - Both sets contain {0} integer(s): ", allValues.Count);
            DisplaySet(allValues);

            // ---------------------------------------------------------

            // Create a new empty HashSet for just integers that belong to both groups
            HashSet<int> both = new HashSet<int>(set_a);

            // perform an INTERSECT operation
            both.IntersectWith(set_b);

            // display the union
            Console.WriteLine("\nINTERSECTION - integers that occur in both sets: {0} ", both.Count);
            DisplaySet(both);

            // ---------------------------------------------------------

            // Create a new empty HashSet for set_a only (not set_b)
            HashSet<int> set_aOnly = new HashSet<int>(set_a);


            //  perform a DIFFERENCE / ExceptWith operation
            set_aOnly.ExceptWith(set_b);

            // display set_a exclusively
            Console.WriteLine("\nDIFFERENCE - integers that occus only in set_b exclusively - No set_a: {0}", set_aOnly.Count);
            DisplaySet(set_aOnly);

            // ---------------------------------------------------------

            // Create a new empty HashSet for integers in set_a or set_b only - not both
            HashSet<int> onlyOneSet = new HashSet<int>(set_a);

            //  perform a ExceptWith / DIFFERENCE operation
            onlyOneSet.SymmetricExceptWith(set_b);

            // display integers only in one set
            Console.WriteLine("\nSYMMETRIC DIFFERENCE - integers that are only in set_b or set_a - not both: {0}", onlyOneSet.Count);
            DisplaySet(onlyOneSet);

            Console.ReadKey();

        }
    }
}

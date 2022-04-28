using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//find min, max, avg
/*
namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size");
            int []ar = new int[Convert.ToInt32(Console.ReadLine())];
            for(int i= 0; i < ar.Length; i++)
            {
                Console.WriteLine("the elements at "+i);
                ar[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("the elements are ");
            for(int i= 0; i < ar.Length; i++)
            {
                Console.WriteLine(ar[i]);
            }
            Console.WriteLine("the average of elements: "+ar.Average());
            Console.WriteLine("the min element: "+ar.Min()+" "+"and "+"the max element: "+ar.Max());
        }
    }
}
*/

//accept and display String 
/*
namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nEnter a String");
            String s1 = Console.ReadLine();
            Console.WriteLine("the given input: " + s1);
        }
    }
}
*/

//String reverse
/*
namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nEnter a String");
            String s2 = Console.ReadLine();
            String revs = "";
            for (int i = s2.Length - 1; i >= 0; i--)
            {
                revs += s2[i].ToString();
            }
            Console.WriteLine("the reversed String: " + revs);
        }
    }
}
*/

//palindrome

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nEnter a String");
            String s = Console.ReadLine();
            String rev = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                rev += s[i].ToString();
            }
            if (rev == s)
            {
                Console.WriteLine("the String is {0} and reversed String is {1} ", s, rev);
            }
            else
            {
                Console.WriteLine("not a palindrome");
            }
            Console.ReadLine();
        }
    }
}






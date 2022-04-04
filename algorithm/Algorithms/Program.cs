using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithamPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
           
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\n1.Binary Search \n2.insertion sort \n3.check Anagram \n4.Bubble sort \n5.Merge Sort \n7.Exit ");
                Console.WriteLine("\nEnter Your Option:");
                int option = Convert.ToInt32(Console.ReadLine());    
                switch (option)
                {
                    case 1:
                        BinarySearch binary = new BinarySearch();
                        binary.Search();
                        break;

                    case 2:
                        InsertionSort insertion = new InsertionSort();
                        insertion.Insertion_Sort();
                        break;

                    case 3:
                        Anagram anagram = new Anagram();
                        anagram.Check_Anagram();
                        break;

                    case 4:
                        BubbleSort sort = new BubbleSort();
                        sort.Bubble_Sort();
                        break;
                    case 5:
                        MergeSort sortMerge = new MergeSort();
                        sortMerge.Merge_Sort();
                        break;
                    case 6:
                        PrimeNumbers numbers = new PrimeNumbers();
                        numbers.Prime();
                        break;
                    case 7:
                        flag = false;
                        break;

                    default:
                        Console.WriteLine("Wrong option! please enter option again.");
                        break;
                }
            }
           
            Console.ReadKey();
        }
    }
}
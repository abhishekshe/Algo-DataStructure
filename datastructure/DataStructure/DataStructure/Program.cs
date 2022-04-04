using System;
namespace LinkedList
{
    class Program
    {
        public static void Main(String[] args)
        {
            try
            {
                Console.WriteLine("1. Unorderd array \n2.Ordered array");
                Console.WriteLine("enter your option:");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        UnorderedList list = new UnorderedList();
                        list.Unorderd();
                        break;

                    case 2:
                        OrderedList check = new OrderedList();
                        check.Ordered();
                        break;

                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("invalid input!!");
                Console.WriteLine(e);
            }
            Console.ReadKey();
        }
    }
}
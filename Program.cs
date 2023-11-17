using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Day10Assignment1
{
    internal class Program
    {
        public static int BinarySearch(int[] arr, int num)
        {
            int[] arr1 = new int[num];

            for (int i = 0; i < arr.Length; i++)
            {
                arr1[i] = arr[i];
            }

            Array.Sort(arr1);


            int high = arr.Length - 1;
            int low = 0;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (arr[mid] == num)
                {
                    return mid;
                }
                else if (arr[mid] < num)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }

            }
            return -1;


        }
        public static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Bubble sort in descending order");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

        }
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Enter the size of array");
            size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter the element which u want to insert in the array");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter no 1 for binary search and 2 for bubble sort");
            int ex = int.Parse(Console.ReadLine());
            switch (ex)
            {
                case 1:
                    {
                        Console.WriteLine("Enter the number which you want to search in binary search");
                        int num = int.Parse(Console.ReadLine());

                        int res = BinarySearch(arr, num);
                        if (res != -1)
                        {
                            Console.WriteLine("Element found at index  " + res);
                        }
                        else
                        {
                            Console.WriteLine("Array index is not found");
                        }
                        break;
                    }
                case 2:
                    {
                        BubbleSort(arr);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Enter wrong case");
                        break;
                    }
            }
            Console.ReadKey();

        }
    }
}
        
        
    


    


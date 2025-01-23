using System.Diagnostics;
using System.Transactions;

namespace compare_algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random n = new Random();
            Stopwatch sw = new Stopwatch();
            Console.WriteLine("enter an array please");
            int ArraySize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a new item size please");
            int ItemSize = Convert.ToInt32(Console.ReadLine());
            //int[] array = CreateArray(ArraySize, n);

            menu();
        }
        static int[] CreateArray(int size, int minimumvalue, int maximumvalue)
        {
            Random r = new Random();
            int[] a = new int[size];
            for (int i = 0; i < a.Length; ++i)
            {
                a[i] = r.Next(minimumvalue, maximumvalue);
            }
            return a;
        }
        static void menu()
        {
            Console.WriteLine("enter 1 for linear search");
            Console.WriteLine("enter 2 for binary search");
            Console.WriteLine("enter 3 for bubble search");
            Console.WriteLine("enter 4 for merge search");
            Console.WriteLine("enter 9 to quit");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the size of the array please");
            Console.WriteLine("enter your minimum value for array please");
            int minimumvalue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter you maximum value for array please");
            int maximumvalue = Convert.ToInt32(Console.ReadLine());
        }

        static void BubbleSort(int[] a)
        {
            for (int i = 0;i<a.Length i++)
            {

            }
        }
        static void Merge(int[] a, int low, int mid, int high)
        {
            int i, j, k;
            int num1 = mid - low + 1;
            int num2 = high - mid;
            int[] L = new int[num1];
            int[] R = new int[num2];
            for (i = 0; i < num1; i++)
            {
                L[i] = a[low + i];
            }
            for (j = 0; j < num2; j++)
            {
                R[j] = a[mid + j + 1];
            }
            i = 0;
            j = 0;
            k = low;
            while (i < num1 && j < num2)
            {
                if (L[i] <= R[j])
                {
                    a[k] = L[i];
                    i++;
                }
                else
                {
                    a[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < num1)
            {
                a[k] = L[i];
                i++;
                k++;
            }
            while (j < num2)
            {
                a[k] = R[j];
                j++; k++;
            }
        }
        static void MergeSortRecursive(int[] a, int low, int high)
        {
            if (low < high)
            {
                int mid = (low + high) / 2;
                MergeSortRecursive(a, low, mid);
                MergeSortRecursive(a, mid + 1, high);
                Merge(a, low, mid, high);
            }
        }
        static bool LinearSearch(int[] a, int numToFind)
        {
            bool found = false;
            {
                for (int i = 0; i < a.Length; i++)
                    if (a[i] == numToFind)
                    {
                        found = true;
                        Console.WriteLine($"your number was found at index {i}");
                        break;
                    }
                if (found == false)
                {
                    Console.WriteLine("your number was not found");
                }
                return found;
            }


            //static bool BinarySearch(int[] a, int numToFind)
            //{

            //}
        }
    }
}

            


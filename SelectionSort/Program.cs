using System;

namespace SelectionSort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var array = new[] { 1, 43, 56, 76, 23, 43, 89, 123, 56, 0, 23, 12, 5, 8, 100 };
            Console.WriteLine("The Initial array is:");
            Print(array);

            int temp, smallest;

            for (int i = 0; i < array.Length - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[smallest])
                        smallest = j;
                }

                temp = array[smallest];
                array[smallest] = array[i];
                array[i] = temp;
            }

            Console.WriteLine("Sorted Array:");
            Print(array);

            Console.ReadLine();
        }

        private static void Print(int[] array)
        {
            int length = array.Length;

            for (int i = 0; i < length; ++i)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }
    }
}

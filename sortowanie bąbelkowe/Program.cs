using System;

namespace BubbleSortExample
{
    class Program
    {
        static void BubbleSort(int[] array)
        {
            int n = array.Length;
            do
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
                n--;
            }
            while (n > 1);
        }

        static void Main()
        {
            Console.Write("Podaj rozmiar tablicy: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[size];
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1, 100);
            }

            Console.WriteLine("\nPrzed sortowaniem:");
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }

            BubbleSort(array);

            Console.WriteLine("\n\nPo sortowaniu:");
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }

            Console.ReadKey();
        }
    }
}

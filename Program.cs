internal partial class Program
{
    private static void Main(string[] args)
    {
        //Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
        //Напишите программу, которая покажет количество чётных чисел в массиве.
        //[345, 897, 568, 234] -> 2

        void zadacha34()
        
            {
            int size = 6;
            int [] array = new int [size];
            FillArray(array,99, 1000);
            PrintArray(array);
            even(array);
            
          

            Console.WriteLine ($"в этом массиве {even(array)} четных чисел");
            }
            
            int even(int[] array)
            {
                int even = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i]%2==0) even = even+1;
                }
                return even;

            }

            void FillArray(int[] array, int startNumber=0, int finishNumber=0 )
            {
                Random random = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(startNumber, finishNumber);
                }
                
            }
            void PrintArray(int[] array)
            {
                Console.WriteLine("Вывод Массива:");
                for ( int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine();
            }
            // Задача 36: Задайте одномерный массив, заполненный случайными числами.
            // Найдите сумму элементов, стоящих на нечётных позициях.
            //[3, 7, 23, 12] -> 19
            //[-4, -6, 89, 6] -> 0

        void zadacha35()
        {
            int size = 6;
            int [] array = new int [size];
            FillArray(array,-99, 100);
            PrintArray(array);
            sumEven(array);
            
            Console.WriteLine ($"сумма чисел стоящин на не четных местах равна: {sumEven(array)}");


            int sumEven(int[] array, int sum=0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (i%2<=0) sum += array[i];

                }
                return sum;
            }


        }

        //Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным 
        //и минимальным элементов массива.
        //[3 7 22 2 78] -> 76



        void zadacha36()
        {
            Random random = new Random();
            Double[] array =new double[8];

            

            for (int i = 0; i< array.Length; i++ )
            {
                array[i]=Math.Round(random.NextDouble()*10-5, 2);
            }

             Console.WriteLine("Вывод Массива:");
                for ( int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine();
            Double max =array[0];
            Double min =array[0];
                for (int i =0; i< array.Length; i++)
                {
                    if (array[i] > max) max = array[i];
                    else if (array[i]<min) min = array[i];
                }
            Console.WriteLine($"Максимальное значение равно: {max}");
            Console.WriteLine($"Минимальное значение равно: {min}");
            Console.WriteLine($"Разница равна {Math.Round(max-min, 2)}");

            


        }



        zadacha34();
        zadacha35();
        zadacha36();
    }
}
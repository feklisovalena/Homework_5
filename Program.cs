// Задача 34: Задайте массив заполненный 
// случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество 
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2






// System.Console.Write("Введите количество элементов в массиве: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// int count = 0;
// for(int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(100,1000);
//     System.Console.Write(array[i]+" ");
//     if(array[i] % 2 == 0)
//     {
//         count++;
//     }
// } 
// System.Console.WriteLine();
// System.Console.WriteLine(count++);










// Задача 36: Задайте одномерный массив, заполненный 
// случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0




// System.Console.Write("Введите количество элементов в массиве ");
// int num = Convert.ToInt32(Console.ReadLine());

// int [] array = new int[num];
// int sum = 0;
 
// for (int i = 0; i < array.Length; i++)
// {
//     array[i]= new Random().Next(0,100);
//     System.Console.Write(array[i] + " ");
//     if(array[i]% 2 ==1)
//     {
//         sum +=array[i];
//     }

// }
// System.Console.WriteLine("");
// System.Console.WriteLine(sum);












// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76





// Console.WriteLine("Введите размер массива ");
// int size = Convert.ToInt32(Console.ReadLine());
// double[] numbers = new double[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("массив: ");
// PrintArray(numbers);
// double min = Int32.MaxValue;
// double max = Int32.MinValue;

// for(int z = 0; z< numbers.Length; z++)
// {
//     if(numbers[z]>max)
//     {
//         max = numbers[z];
//     }
//     if (numbers[z]<min)
//     {
//         min = numbers[z];
//     }

// }

// Console.WriteLine($"всего {numbers.Length} чисел.Максимальное значение = {max}, минимальное значение = {min}");
// Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

// void FillArrayRandomNumbers(double[] numbers)
// {
//     for (int i=0; i < numbers.Length; i++)
//     {
//         numbers[i] = Convert.ToDouble(new Random().Next(100,1000))/100;
//     }
// }
// void PrintArray(double[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.Write("[");
//     Console.WriteLine();
// }
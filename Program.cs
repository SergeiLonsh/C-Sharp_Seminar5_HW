// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// int [] randomarray = new int [4];
// int pos = 0;

//    for (int i =0; i< randomarray.Length; i++)
// {
//    randomarray[i] = new Random().Next(100,1000);
      
// Console.Write($"{randomarray[i]} ");  
// }
      
//    for (int i=0; i < randomarray.Length; i++)
//      {
//         if (randomarray[i] % 2 == 0)
//         {
//            pos = pos + 1;
//         }
           
//      }
  
// Console.Write("=> "+pos);
// __________________________________________________________________________________

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int [] randomarray = new int [4];
// int res = 0;

// for (int i =0; i< randomarray.Length; i++)
//   {
//    randomarray[i] = new Random().Next(-100,100);

// Console.Write($"{randomarray[i]} ");  
//    }
// for (int i =0; i< randomarray.Length; i++)
//    {
//       if (randomarray[i] % 2 != 0)
//       {
//       res = res + randomarray[i];
//       }
//    }
// Console.Write("=> "+res);
// __________________________________________________________________________________


// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


// Console.Write("Введите количество элементов массива: ");
// int a = Convert.ToInt32(Console.ReadLine());
// double[] ranArr = new double[a];

// void FillArray (int a)
// {
// Random random = new Random();
// for (int i = 0; i < a; i++)
// {
// ranArr[i] = random.NextDouble() *100;
// Console.Write($"{ranArr[i]:F3} ");
// }

// }

// double odds(double[] ranArr)
// {
// double maxNum = ranArr[0];
// double minNum = ranArr[0];
// int i = 1;
// while (i < ranArr.Length)
// {
// if (maxNum<ranArr[i])
// maxNum = ranArr[i];
// if (minNum>ranArr[i])
// minNum = ranArr[i];
// i = i + 1;
// }
// return maxNum-minNum;
// }
// FillArray (a);
// Console.Write($"\nРазница между максимальным и минимальным элементов массива: {odds(ranArr):F3}");
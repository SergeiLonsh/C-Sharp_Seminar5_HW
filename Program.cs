// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int [] randomarray = new int [4];

        int i=0;
while (i< randomarray.Length)
{
   randomarray[i] = new Random().Next(100,1000);
      
Console.Write($"{randomarray[i]} ");  
i++; 
}

     int pos = 0;
     int res;    
    while (i < randomarray.Length)
     {
        res = randomarray[i] % 10 % 2;

        if ( res == 0)
        {
           pos = pos + 1;
        }
        else 
        pos = pos;
    i++;
        
     }
Console.Write("=> "+pos);
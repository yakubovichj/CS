﻿//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// int[,,] InitializateArray(int m, int n, int p)
// {
//     return new int[m,n,p];
// }

// int m = GetNumberFromConsole("Введите размерность массива  m");
// int n = GetNumberFromConsole("Введите размерность массива  n");
// int p = GetNumberFromConsole("Введите размерность массива  p");
// int[,,] array = InitializateArray(m,n,p);

// FillArray(array);
// PrintArray(array);
// Console.WriteLine();



// int GetNumberFromConsole(string text)
// {
//     Console.WriteLine(text);
//     return Convert.ToInt32(Console.ReadLine());
// }


// void FillArray(int[,,] arr)
// {   int temp = new int[arr.GetLength(0),  arr.GetLength(1), arr.GetLength(2)];
//     int number;
//     for(int i = 0; i < temp.GetLength(0); i++)
//     {
//         temp[i] = new Random().Next(10,100);
//         number = temp[i];
//         if (i >= 1)
//         {
//             for(int j = 0; j < i; j++)
//             {
//                 while (temp[i] == temp[j])
//                 {
//                     temp[i] = new Random().Next(10,100);
//                     j = 0;
//                     number = temp[i];
//                 }    
//                 number = temp[i];
//             }    
//         }
//     }

//     int count = 0;
//     for (int m = 0; n < arr.GetLength(0); m++)
//         {
//            for (int n = 0; m < arr.GetLength(1); n++)

//             {
//                 for (int p = 0; m < arr.GetLength(2); p++)
//                 {
//                     arr[m,n,p] = temp[count];
//                     count++;
//                 }
//             }
//         }

// }

// void PrintArray(int[,,] arr)
// {
//     for(int i = 0; i < arr.GetLength(0); i++)
//     {
//         for(int j = 0; j < arr.GetLength(1); j++)
//         {
//             for(int k = 0; k < arr.GetLength(2); k++)
//             {
//                 Console.Write(arr[i,j,k] + " ");
//             }
//                 Console.WriteLine();
//         }   
//     }
// }


int x = InputNumbers("Введите X: ");
int y = InputNumbers("Введите Y: ");
int z = InputNumbers("Введите Z: ");
Console.WriteLine($"");

int[,,] array3D = new int[x, y, z];
FillArray(array3D);
PrintArray(array3D);

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void PrintArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={array3D[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void FillArray(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}


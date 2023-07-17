﻿/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

int InPut(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] Array(int row, int column, int leftRange, int rightRange)
{
    Random rand = new Random();

    int[,] array = new int[row, column];

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return array;
}
void PrintArray(int[,] arrayForPrint)
{
    for(int i = 0; i < arrayForPrint.GetLength(0); i++)
    {
        for(int j = 0; j < arrayForPrint.GetLength(1); j++)
        {
            System.Console.Write(arrayForPrint[i,j] + "\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine("\n");
}

void PrintArray2(int[,] arrayForPrint)
{
    int last = 0;
    for(int i = 0; i < arrayForPrint.GetLength(0); i++)
    {
        last = arrayForPrint.GetLength(0);
        for(int j = 0; j < arrayForPrint.GetLength(1); j++)
        {
            if(arrayForPrint[i, j] < last)
            {
                last = arrayForPrint[i, j];
            }
            else if(arrayForPrint[i, j] > last)
            {
                arrayForPrint[i, j - 1] = arrayForPrint[i, j];
                arrayForPrint[i, j] = last;
            }
            else if(arrayForPrint[i, j] == last) continue;
        }
    }
    PrintArray(arrayForPrint);
}

int row = InPut("Enter a row: ");
int column = InPut("Enter a column: ");
int leftRange = InPut("Enter a left range: ");
int rightRange = InPut("Enter a right range: ");
int[,] matrix = Array(row, column, leftRange, rightRange);

PrintArray(matrix);
PrintArray2(matrix);
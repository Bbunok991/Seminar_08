/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

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

int row = InPut("Enter a row: ");
int column = InPut("Enter a column: ");
int leftRange = InPut("Enter a left range: ");
int rightRange = InPut("Enter a right range: ");
int[,] matrix = Array(row, column, leftRange, rightRange);

PrintArray(matrix);
PrintArray2(matrix);
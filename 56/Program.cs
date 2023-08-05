/* Задача 56: 
Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }

}

void SumMinLine(int[,] matrix)
{
    int[] SumLineArr = new int[matrix.GetLength(0)];
    int SumLine;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        SumLine = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            SumLine += matrix[i, j];
        }
        SumLineArr[i] = SumLine;
    }

    int SumMinArr = SumLineArr[0];
    int NumLine = 1;
    for (int k = 0; k < SumLineArr.Length; k++)
    {
        if (SumLineArr[k] < SumMinArr)
        {
            SumMinArr = SumLineArr[k];
            NumLine = k + 1;
        }
    }
    Console.Write($"Минимальной является строка {NumLine}, сумма строки равна {SumMinArr}.");
}

Console.Clear();
Console.Write("Введите размеры матрицы через пробел: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine($"_________________________________________");
SumMinLine(matrix);

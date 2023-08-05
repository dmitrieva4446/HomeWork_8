/* Задача 60.
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int[,,] fillArray(int line, int column, int height)
{
    int[,,] filledArr = new int[line, column, height];
    int tempSize = line * column * height;
    if (tempSize <= 90)
    {
        int[] tempArr = Unique(tempSize);
        int iTemp = 0;

        for (int i = 0; i < line; i++)
            for (int j = 0; j < column; j++)
                for (int k = 0; k < height; k++)
                    if (iTemp >= 0 && iTemp < tempSize)
                    {
                        filledArr[i, j, k] = tempArr[iTemp];
                        iTemp++;
                    }
    }
    return filledArr;
}


void Show3DArray(int[,,] showArray)
{
    for (int i = 0; i < showArray.GetLength(0); i++)
    {
        for (int j = 0; j < showArray.GetLength(1); j++)
        {
            for (int k = 0; k < showArray.GetLength(2); k++)
            {
                Console.Write($"{showArray[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine(" ");
    }
}

int[] Unique(int size)
{
    int[] unArr = new int[size];
    for (int i = 0; i < size; i++)
    {
        unArr[i] = new Random().Next(10, 100);
        if (i != 0)
        {
            for (int r = 0; r < i; r++)
            {
                while (unArr[r] == unArr[i])
                {
                    unArr[r] = new Random().Next(10, 100);
                }
            }
        }
    }
    return unArr;
}

Console.Clear();
Console.Write("Введите количество строк в трехмерном массиве: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в трехмерном массиве: ");
int column = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите высоту трехмерного массива: ");
int height = Convert.ToInt32(Console.ReadLine());

int[,,] Array3D = fillArray(line, column, height);
Show3DArray(Array3D);
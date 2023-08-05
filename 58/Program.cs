/* Задача 58: 
Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
int[,] Create2dArray(int lines, int columns)
{
    int[,] createdArray = new int[lines, columns];
    for (int i = 0; i < lines; i++)
        for (int j = 0; j < columns; j++)
            createdArray[i, j] = new Random().Next(0, 10);
    return createdArray;
}

void ShowArray(int[,] showedArray)
{
    for (int i = 0; i < showedArray.GetLength(0); i++)
    {
        for (int j = 0; j < showedArray.GetLength(1); j++)
        {
            Console.Write(showedArray[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

/*int[,] ProductMatrix (int[,] arr1, int[,] arr2)
{
    int[,] finalMatrix = new int[arr1.GetLength(0), arr2.GetLength(1)];

    for (int i = 0; i < arr1.GetLength(0); i++)
        for (int j = 0; j < arr2.GetLength(1); j++)
            for (int k = 0; k < arr2.GetLength(0); k++)
                finalMatrix[i,j] += arr1[i,k] * arr2[k,j];
    return finalMatrix;
}
*/
int[,] ProductMatrix(int[,] arr1, int[,] arr2)
{
    int[,] finalMatrix = new int[arr1.GetLength(0), arr2.GetLength(1)];

    for (int i = 0; i < arr1.GetLength(0); i++)
        for (int j = 0; j < arr2.GetLength(1); j++)
            for (int k = 0; k < arr2.GetLength(0); k++)
                finalMatrix[i, j] += arr1[i, k] * arr2[k, j];
    return finalMatrix;
}

Console.Clear();
Console.Write("Введите количество строк первой матрицы: ");
int lines1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов первой матрицы: ");
int columns1 = Convert.ToInt32(Console.ReadLine());
int lines2 = columns1;
Console.Write("Введите количество столбцов второй матрицы: ");
int columns2 = Convert.ToInt32(Console.ReadLine());

int[,] Matrix1 = Create2dArray(lines1, columns1);
ShowArray(Matrix1);
int[,] Matrix2 = Create2dArray(lines2, columns2);
ShowArray(Matrix2);
Console.WriteLine($"_________________________________________");
int[,] resultProductMatrix = ProductMatrix(Matrix1, Matrix2);
ShowArray(resultProductMatrix);

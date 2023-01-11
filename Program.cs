/*
Console.WriteLine("Задача 54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию");
Console.WriteLine("элементы каждой строки двумерного массива.");
void Show2dArray(int[,] array)// метод выводит массив
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t");

        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] CreateRandom2dArray(int m, int n, int min, int max)// размер массива, минимальное его число и максимальное число
{
    int[,] array = new int[m, n]; //выделили память для двумерного массива
    for (int i = 0; i < m; i++)//идет по столбцам
        for (int j = 0; j < n; j++)//идёт по строкам
            array[i, j] = new Random().Next(min, max);//рандомно заполняем массив

    return array;
}
void Sort2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int z = 0; z < array.GetLength(1) - 1; z++)
            {
                if (array[i, z] < array[i, z + 1]) //для изменения сортировки поменять знак < на противоположный
                {
                    int temp = 0;
                    temp = array[i, z];
                    array[i, z] = array[i, z + 1];
                    array[i, z + 1] = temp;
                }
            }
        }
    }
}

Console.Write("Введите кол-во строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите min элемент: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите max элемент: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, minValue, maxValue);
Show2dArray(myArray);
Sort2dArray(myArray);
Console.WriteLine("Отсортированный массив");
Show2dArray(myArray);
*/
/*
Console.WriteLine("Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку");
Console.WriteLine("с наименьшей суммой элементов.");
void Show2dArray(int[,] array)// метод выводит массив
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t");

        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] CreateRandom2dArray(int m, int n, int min, int max)// размер массива, минимальное его число и максимальное число
{
    int[,] array = new int[m, n]; //выделили память для двумерного массива
    for (int i = 0; i < m; i++)//идет по столбцам
        for (int j = 0; j < n; j++)//идёт по строкам
            array[i, j] = new Random().Next(min, max);//рандомно заполняем массив

    return array;
}
int MinSumString(int[,] array)
{
    int indexres=0;
    int minsum = Int32.MaxValue;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum=0;
        int index=1;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum+=array[i,j];//суммируем элементы строки i в цикле по j элементам
            
        }
        Console.WriteLine($"String {i+1} sum = {sum}");
        if(sum<minsum)
        {
            minsum=sum;
            index++;
            indexres=index;//сохраняем индекс строки в которой минимальная сумма
        }       
    }
    return indexres;
}

Console.Write("Введите кол-во строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите min элемент: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите max элемент: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, minValue, maxValue);
Show2dArray(myArray);
int result = Convert.ToInt32(MinSumString(myArray));
Console.WriteLine($"строка с наименьшей суммой элементов под номером: {result} ");
*/
/*
Console.WriteLine("Задача 58: Задайте две матрицы. Напишите программу, которая"); 
Console.WriteLine("будет находить произведение двух матриц.");
void Show2dArray(int[,] array)// метод выводит массив
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t");

        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] CreateRandom2dArray(int m, int n, int min, int max)// размер массива, минимальное его число и максимальное число
{
    int[,] array = new int[m, n]; //выделили память для двумерного массива
    for (int i = 0; i < m; i++)//идет по столбцам
        for (int j = 0; j < n; j++)//идёт по строкам
            array[i, j] = new Random().Next(min, max);//рандомно заполняем массив

    return array;
}
int[,] CreateRandom2dArray2(int m, int n, int min, int max)// размер массива, минимальное его число и максимальное число
{
    int[,] array2 = new int[m, n]; //выделили память для двумерного массива
    for (int x = 0; x < m; x++)//идет по столбцам
        for (int y = 0; y < n; y++)//идёт по строкам
            array2[x, y] = new Random().Next(min, max);//рандомно заполняем массив

    return array2;
}

int[,] ProizvedenieArray(int[,] arrayA, int[,] arrayB)
{
    int m = arrayA.GetLength(0);
    int n = arrayA.GetLength(1);
    int[,] arrayC= new int[m,n];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayA.GetLength(1); j++)
        {
            for (int k = 0; k < arrayB.GetLength(1); k++)
            {
                arrayC[i,j]+=arrayA[i,k]*arrayB[k,j];
            }
        }
    }
    return arrayC;
}                   

            


Console.Write("Введите кол-во строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите min элемент: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите max элемент: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, minValue, maxValue);
int[,] myArray2 = CreateRandom2dArray2(m, n, minValue, maxValue);
Show2dArray(myArray);
Show2dArray(myArray2);
int[,] NewArray = ProizvedenieArray(myArray,myArray2);
Show2dArray(NewArray);
*/
/*
Console.WriteLine("Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.");
Console.WriteLine("Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого") ;
Console.WriteLine("элемента.Массив размером 2 x 2 x 2");
void Show3dArray(int[,,] array)// метод выводит массив
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("| ");//разделяем двумерный массив от глубины
            for (int k = 0; k < array.GetLength(2); k++)
               Console.Write(array[i, j, k] + $"({i},{j},{k}) \t "); //вывод значеиния и индексов          
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,,] CreateRandom3dArray(int m, int n, int b, int min, int max)// размер массива, минимальное его число и максимальное число
{
    int[,,] array = new int[m, n, b]; //выделили память для двумерного массива
    for (int i = 0; i < m; i++)//идет по столбцам
        for (int j = 0; j < n; j++)//идёт по строкам
            for (int k = 0; k < b; k++)// идёт по глубине
                array[i, j, k] = new Random().Next(min, max);//рандомно заполняем массив  
    return array;
}

Console.Write("Введите кол-во строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во строк в глубине b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите min элемент: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите max элемент: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,,] myArray = CreateRandom3dArray(m, n, b, minValue, maxValue);
Show3dArray(myArray);
*/

Console.WriteLine("Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.");
void Show2dArray(int[,] array)// метод выводит массив
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t");

        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] CreateArray(int size)// размер массива 4*4
{
    int[,] nums = new int[size, size];

    int num = 1;
    int i = 0;
    int j = 0;

    while (num <= size*size)
    {
        nums[i, j] = num;
        if (i <= j + 1 && i + j < size - 1)//идём по строке пока наша сумма i+j не станет меньше size-1
                                           // когда не выполняется условие мы переходим к следующему If
            ++j;
        else if (i < j && i + j >= size - 1)// тут если условие выполняется мы переходим на строку вниз
            ++i;
        else if (i >= j && i + j > size - 1)//когда дошли поворот
            --j;
        else
            --i;
        ++num;
    }
    return nums;
}


Console.Write("Введите кол-во строк и столбцов sizeArray: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateArray(sizeArray);
Show2dArray(myArray);

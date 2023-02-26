// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента. Массив размером 2 x 2 x 2

int[,,] GetMassiv (int row, int col, int deep, int minValue, int maxValue) 
{
    int[,,] massiv = new int[row, col, deep];
    Random value = new Random();  
    
    for (int i = 0; i < massiv.GetLength(0); i++) 
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            for (int k = 0; k < massiv.GetLength(2); k++)
                {
                    massiv[i,j,k] = value.Next(minValue, maxValue + 1);
                }
        }
    }
    return massiv;
} 
 
void PrintMassiv(int[,,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++) 
        {
            for (int k = 0; k < massiv.GetLength(2); k++)
            {
                Console.Write($"{massiv[i, j, k], 1}({i},{j},{k})|\t "); 
            }
        }
        Console.WriteLine();        
    }        
}
 
Console.Clear();
Console.WriteLine("Введите количнство строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количнство столбцов: ");
int col = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество глубины: ");
int deep = int.Parse(Console.ReadLine()!);

int[,,] matrix = GetMassiv(row, col, deep, 0, 100);
PrintMassiv(matrix);
Console.WriteLine();
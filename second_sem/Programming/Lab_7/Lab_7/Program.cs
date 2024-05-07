namespace Lab_7;

using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Создание матриц
            SquareMatrix matrix1 = new SquareMatrix(1, 2, 3, 4);
            SquareMatrix matrix2 = new SquareMatrix(2, 4, 6, 8);
            
            // SquareMatrix invalidMatrix = new SquareMatrix(new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } });

            // Вывод исходных матриц
            Console.WriteLine("Исходная матрица 1:");
            Console.WriteLine(matrix1.ToString());

            Console.WriteLine("Исходная матрица 2:");
            Console.WriteLine(matrix2.ToString());

            // Выполнение различных операций с матрицами
            SquareMatrix sum = matrix1 + matrix2;
            Console.WriteLine("\nСумма матриц:");
            Console.WriteLine(sum.ToString());

            SquareMatrix difference = matrix1 - matrix2;
            Console.WriteLine("\nРазность матриц:");
            Console.WriteLine(difference.ToString());

            int scalar = 2;
            SquareMatrix scaledMatrix = matrix1 * scalar;
            Console.WriteLine($"\nМатрица 1, умноженная на {scalar}:");
            Console.WriteLine(scaledMatrix.ToString());

            scalar = 3;
            SquareMatrix dividedMatrix = matrix2 / scalar;
            Console.WriteLine($"\nМатрица 2, разделенная на {scalar}:");
            Console.WriteLine(dividedMatrix.ToString());

            Console.WriteLine("\nИнкремент матрицы 1:");
            Console.WriteLine((matrix1++).ToString());
            Console.WriteLine("\nДекремент матрицы 2:");
            Console.WriteLine((--matrix2).ToString());

            Console.WriteLine("\nПроверка на равенство:");
            Console.WriteLine(matrix1 == matrix2); // должно вернуть false
            Console.WriteLine("\nПроверка на неравенство:");
            Console.WriteLine(matrix1 != matrix2); // должно вернуть true

            Console.WriteLine("\nПроверка условия true:");
            Console.WriteLine(matrix1 ? "Матрица 1 не вырожденная." : "Матрица 1 вырожденная.");
            Console.WriteLine("\nПроверка условия false:");
            Console.WriteLine(matrix2 ? "Матрица 2 не вырожденная." : "Матрица 2 вырожденная.");

            int determinant1 = (int)matrix1;
            Console.WriteLine($"\nОпределитель матрицы 1: {determinant1}");

            SquareMatrix reconstructedMatrix = new SquareMatrix(determinant1, 0, 0, determinant1);
            Console.WriteLine("\nВосстановленная матрица из определителя:");
            Console.WriteLine(reconstructedMatrix.ToString());
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}


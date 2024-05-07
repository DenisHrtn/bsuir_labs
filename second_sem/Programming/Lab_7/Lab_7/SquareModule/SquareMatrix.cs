namespace Lab_7;

public class SquareMatrix
{
    private int[,] matrix = new int[2, 2];

    // индексатор для досутупа к элементам матрицы
    public int this[int row, int col]
    {
        get { return matrix[row, col]; }
        set { matrix[row, col] = value; }
    }
    
    // конструктор
    public SquareMatrix()
    {
        // заполняем по умолчанию 0
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                matrix[i, j] = 0;
            }
        }
    }
    
    public SquareMatrix(int a, int b, int c, int d)
    {
        // Проверка на квадратную матрицу 2x2
        if (a < int.MinValue || a > int.MaxValue ||
            b < int.MinValue || b > int.MaxValue ||
            c < int.MinValue || c > int.MaxValue ||
            d < int.MinValue || d > int.MaxValue)
        {
            throw new ArgumentException("Значения выходят за допустимый диапазон.");
        }

        matrix[0, 0] = a;
        matrix[0, 1] = b;
        matrix[1, 0] = c;
        matrix[1, 1] = d;
    }

    public SquareMatrix(int[,] initialValues)
    {
        if (initialValues.GetLength(0) != 2 || initialValues.GetLength(1) != 2)
        {
            throw new ArgumentException("Массив должен быть двумерным и иметь размерность 2x2.");
        }

        matrix = initialValues;
        // Проверка на допустимый диапазон значений в матрице
        foreach (int value in matrix)
        {
            if (value < int.MinValue || value > int.MaxValue)
            {
                throw new ArgumentException("Значения в матрице выходят за допустимый диапазон.");
            }
        }
    }

    
    // перегрузка ToString
    public override string ToString()
    {
        return $"[{matrix[0, 0]}, {matrix[0, 1]}\n {matrix[1, 0]}, {matrix[1, 1]}]";
    }
    
    // перегрузка  сложения матрицы
    public static SquareMatrix operator +(SquareMatrix m1, SquareMatrix m2)
    {
        SquareMatrix result = new SquareMatrix();
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                result[i, j] = m1[i, j] + m2[i, j];
            }
        }

        return result;
    }
    
    // перегрузка вычитания матрицы
    public static SquareMatrix operator -(SquareMatrix m1, SquareMatrix m2)
    {
        SquareMatrix result = new SquareMatrix();
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                result[i, j] = m1[i, j] - m2[i, j];
            }
        }

        return result;
    }
    
    // перегрузка оператора умножения на число
    public static SquareMatrix operator *(SquareMatrix m, int scalar)
    {
        SquareMatrix result = new SquareMatrix();
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                result[i, j] = m[i, j] * scalar;
            }
        }

        return result;
    }
    
    // перегрузка оперетора деления
    public static SquareMatrix operator /(SquareMatrix m, int divisor)
    {
        if (divisor == 0)
        {
            throw new ArgumentException("На ноль делить нельзя!");
        }

        SquareMatrix result = new SquareMatrix();
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                result[i, j] = m[i, j] / divisor;
            }
        }

        return result;
    }
    
    // перегрузка инкремента ++matrix
    public static SquareMatrix operator ++(SquareMatrix m)
    {
        SquareMatrix result = new SquareMatrix();
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                result[i, j] = m[i, j] + 1;
            }
        }
        return result;
    }
    
    // перегрузка инкремента --matrix
    public static SquareMatrix operator --(SquareMatrix m)
    {
        SquareMatrix result = new SquareMatrix();
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                result[i, j] = m[i, j] - 1;
            }
        }
        return result;
    }
    
    // перегрузка оператора равенства ==
    public static bool operator ==(SquareMatrix m1, SquareMatrix m2)
    {
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                if (m1[i, j] != m2[i, j])
                {
                    return false;
                }
            }
        }

        return true;
    }
    
    // перегрузка оператора неравенства
    public static bool operator !=(SquareMatrix m1, SquareMatrix m2)
    {
        return !(m1 == m2);
    }
    
    // перегрузка оператора true
    public static bool operator true(SquareMatrix m)
    {
        return m.Determinant() != 0;
    }
    
    // перегрузка оператора false
    public static bool operator false(SquareMatrix m)
    {
        return m.Determinant() == 0;
    }
    
    // преобразователь типа SqueareMatrix в int ( определитель )
    public static explicit operator int(SquareMatrix m)
    {
        return m.Determinant();
    }

    private int Determinant()
    {
        return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
    }
}

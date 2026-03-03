namespace WorkshopMatrices.Backend;

public class Matrix
{
    // Fields
    private int _n;
    private int[,] _matrix;

    // Constructor
    public Matrix(int n)
    {
        _n = n;
        _matrix = new int[_n, _n];
        FillMatrix();
    }

    // Properties
    public int N => _n;
    public int[,] Values => _matrix;

    // Métodos públicos

    public void FillMatrix()
    {
        for (int i = 0; i < _n; i++)
        {
            for (int j = 0; j < _n; j++)
            {
                _matrix[i, j] = i + j;
            }
        }
    }

    public string ShowMatrix()
    {
        string output = "";

        for (int i = 0; i < _n; i++)
        {
            for (int j = 0; j < _n; j++)
            {
                output += $"{_matrix[i, j],4}";
            }
            output += "\n";
        }

        return output;
    }

    public string ShowLowerTriangular()
    {
        string output = "";

        for (int i = 0; i < _n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                output += $"{_matrix[i, j],4}";
            }
            output += "\n";
        }

        return output;
    }
}

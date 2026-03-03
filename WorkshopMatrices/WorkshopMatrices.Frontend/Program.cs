using WorkshopMatrices.Backend;

Console.Write("Ingrese orden de la matriz: ");
int n = int.Parse(Console.ReadLine());

var matrix = new Matrix(n);

Console.WriteLine("MATRIZ COMPLETA");
Console.WriteLine(matrix.ShowMatrix());

Console.WriteLine("TRIANGULAR INFERIOR");
Console.WriteLine(matrix.ShowLowerTriangular());

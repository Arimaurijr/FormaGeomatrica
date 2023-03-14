using FormaGeomatrica;

internal class Program
{
    private static void Main(string[] args)
    {
        Quadrado quadrado = new Quadrado();
        quadrado.ladoB = 10;
        quadrado.ladoA = quadrado.ladoB;

        Console.WriteLine(quadrado.ToString());
        Console.WriteLine(quadrado.CalcularArea());

        Triangulo triangulo = new Triangulo();

        triangulo.ladoB = 3;
        triangulo.ladoA = 15;

        Console.WriteLine(triangulo.ToString());
        Console.WriteLine(triangulo.CalcularArea());
    }
}
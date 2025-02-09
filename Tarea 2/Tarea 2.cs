class Program
{
    static void Main()
    {
        // Solicitar un número al usuario
        Console.Write("Ingrese un número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        // Verificar si el número es par o impar
        if (numero % 2 == 0)
        {
            Console.WriteLine("El número " + numero + " es par.");
        }
        else
        {
            Console.WriteLine("El número " + numero + " es impar.");
        }
namespace Fibonacci;


class programa
{
    public static void Main(String[] args)
    {
        int n = Ingresarnumero();
        int tiempo1 = (int.Parse($"{DateTime.Now:fffff}"));
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Serie números de fibonacci recursivo: " + fibonacciRecursivo(i) + ", ");
        }
        Console.WriteLine("El tiempo recursivo es: "+ (int.Parse($"{DateTime.Now:fffff}") - tiempo1));
        tiempo1 = (int.Parse($"{DateTime.Now:fffff}"));
        Console.WriteLine("Serie números de fibonacci iterativo: ");
        fibonacciIterativo(n);
        Console.WriteLine("El tiempo iterativo es: "+ (int.Parse($"{DateTime.Now:fffff}") - tiempo1));
    }

    public static int fibonacciRecursivo(int num)
    {
        if (num == 0 || num == 1)
            return num;
        else
            return fibonacciRecursivo(num - 1) + fibonacciRecursivo(num - 2);
    }

    static void fibonacciIterativo(int n)
    {
        int i;
        long ant1, ant2;
        ant1 = ant2 = 1;
        Console.WriteLine("0 \n1 \n1");
        for (i = 1; i <= n - 2; i++)
        {
            long actual = ant1 + ant2;
            Console.WriteLine(actual);
            ant2 = ant1;
            ant1 = actual;
        }
    }

    static int Ingresarnumero()
    {
        Console.Write("Introduzca el número de términos: ");
        int n = Convert.ToInt32(Console.ReadLine());
        return n;
    }


}

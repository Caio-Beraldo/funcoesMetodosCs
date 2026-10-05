using System;

class Program
{
    //Ex.1
    static double Somar(double a, double b)
    {
        return a + b;
    }
    static double Subtrair(double a, double b)
    {
        return a - b;
    }
    static double Multiplicar(double a, double b)
    {
        return a * b;
    }
    static double Dividir(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Não é possível dividir por zero!");
            return 0;
        }

        return a / b;
    }

    // Ex.2 
    static double CalcularMedia(params double[] notas)
    {
        double soma = 0;

        foreach (double nota in notas)
        {
            soma += nota;
        }

        return soma / notas.Length;
    }

    // Ex.3
    static void Dobrar(ref double valor)
    {
        valor = valor * 2;
    }

    // Ex.4
    static int Dividir(int a, int b, out int resto)
    {
        resto = a % b;
        return a / b;
    }

    // EX.5
    static void Log(string mensagem, string nivel = "INFO")
    {
        Console.WriteLine($"[{nivel}] {mensagem}");
    }

    static void Main()
    {
        // Testando os métodos
        Console.WriteLine("Soma: " + Somar(10, 5));
        Console.WriteLine("Subtração: " + Subtrair(10, 5));
        Console.WriteLine("Multiplicação: " + Multiplicar(10, 5));
        Console.WriteLine("Divisão: " + Dividir(10, 5));

        Console.WriteLine("Média: " + CalcularMedia(7, 8, 9));

        double numero = 10;
        Dobrar(ref numero);
        Console.WriteLine("Número dobrado: " + numero);

        int resto;
        int quociente = Dividir(10, 3, out resto);
        Console.WriteLine($"Quociente: {quociente}, Resto: {resto}");

        Log("Programa iniciado");
        Log("Ocorreu um erro", "ERRO");


        // Ex.6
        Console.WriteLine("\n--- MINI CALCULADORA ---");

        Console.Write("Digite o primeiro número: ");
        double n1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double n2 = double.Parse(Console.ReadLine());

        Console.Write("Escolha a operação (+, -, *, /): ");
        string operacao = Console.ReadLine();

        double resultado = 0;

        switch (operacao)
        {
            case "+":
                resultado = Somar(n1, n2);
                break;

            case "-":
                resultado = Subtrair(n1, n2);
                break;

            case "*":
                resultado = Multiplicar(n1, n2);
                break;

            case "/":
                resultado = Dividir(n1, n2);
                break;

            default:
                Console.WriteLine("Operação inválida!");
                return;
        }

        Console.WriteLine("Resultado: " + resultado);
    }
}

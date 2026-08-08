// Calculadora simples

decimal a;
decimal b;
Console.WriteLine("Digite dois valores");

Console.Write("Valor A: ");
decimal.TryParse(Console.ReadLine(), out a);

Console.Write("Valor B: ");
decimal.TryParse(Console.ReadLine(), out b);

Console.WriteLine();
Console.WriteLine("---- Calculadora Simples ----");
Console.WriteLine($"Soma: {a+b:F2}");
Console.WriteLine($"Subtração: {a-b:F2}");
Console.WriteLine($"Multiplicação: {a*b:F2}");
Console.WriteLine($"Divisão: {a/b:F2}");

// Exercício 02 - Antecessor e sucessor

Console.WriteLine("Escreva um número inteiro");

int.TryParse(Console.ReadLine(), out int n);

Console.WriteLine($"Antecessor {n-1}");
Console.WriteLine($"Número informado {n}");
Console.WriteLine($"Sucessor {n + 1}");

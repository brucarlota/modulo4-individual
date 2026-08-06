// Exercício 01 - Soma de dois números

Console.WriteLine("Escreva dois números inteiros");

int.TryParse(Console.ReadLine(), out int valorA);
int.TryParse(Console.ReadLine(), out int valorB);

Console.WriteLine($"A soma é {valorA + valorB}.");

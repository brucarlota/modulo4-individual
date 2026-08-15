// Contagem de pares

int[] numeros = new int[20];
int qtdePares = 0;

for (int i = 0; i < numeros.Length; i++){
	Console.Write($"Número {i+1}: ");
	numeros[i] = int.Parse(Console.ReadLine()!);

	if (i % 2 == 0) qtdePares++;
}

Console.WriteLine($"{qtdePares} números são pares");

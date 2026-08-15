// Média de um vetor

int[] numeros = new int[8];

for (int i = 0; i < numeros.Length; i++){
	Console.Write($"Nota {i+1}: ");
	numeros[i] = int.Parse(Console.ReadLine()!);
}

Console.WriteLine($"Média é {numeros.Sum()/numeros.Length}");

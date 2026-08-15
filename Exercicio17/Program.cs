// Ordem inversa

int[] numeros = new int[8];

for (int i = 0; i < numeros.Length; i++) {
	Console.Write($"valor: ");
	numeros[i] = int.Parse(Console.ReadLine()!);
}

for (int i = numeros.Length - 1; i >= 0; i--) {
	Console.Write($"{numeros[i]} ");
}

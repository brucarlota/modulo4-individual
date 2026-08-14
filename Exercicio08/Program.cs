// Tabuada

Console.WriteLine("Escreva um número inteiro");
int.TryParse(Console.ReadLine(), out int n);

for (int i = 0; i <= 10; i++) {
	Console.WriteLine($"{n} x {i} = {n*i}");
}

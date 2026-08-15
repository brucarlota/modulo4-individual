// Soma até digitar zero

int soma = 0;
int numero;

Console.WriteLine("Digite números para somar. Digite 0 para obter o resultado:");
do {
	numero = int.Parse(Console.ReadLine());
	soma += numero;

} while (numero != 0);

Console.WriteLine($"Soma = {soma}");

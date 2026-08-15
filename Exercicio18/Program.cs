// Jogo da senha

int numeroAleatorio = Random.Shared.Next(1, 101);
int numeroLido;

Console.Write("Digite um número: ");
int.TryParse(Console.ReadLine(), out numeroLido);

if (numeroLido > numeroAleatorio) {
	Console.WriteLine("O número lido é maior que o número sorteado.");
	return;
}
Console.WriteLine("O número lido é menor que o número sorteado.");

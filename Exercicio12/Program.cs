// Contador de caracteres

Console.Write("Digite um nome: ");
string nome = Console.ReadLine()!;

while (nome.Length == 0) {
	Console.Write("Digite um nome válido: ");
	nome = Console.ReadLine()!;
}

Console.WriteLine($"O nome digitado possui {nome.Length} caracteres");

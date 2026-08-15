// Maior elemento

int maior = 0;
int posicao = 0;
int numeroLido;

for (int i = 0; i <= 10; i++) {
	int.TryParse(Console.ReadLine(), out numeroLido);
	if (numeroLido > maior) {
		maior = numeroLido;
		posicao = i;
	}
}

Console.WriteLine($"O maior número inserido foi {maior}, na posição {posicao+1}");

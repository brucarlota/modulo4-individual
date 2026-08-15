// Verificador de senha

Console.Write("Digite uma senha: ");
string senha = Console.ReadLine()!;

while (senha.Length == 0) {
	Console.Write("Digite uma senha válida: ");
	senha = Console.ReadLine()!;
}

if (senha.Length >= 8) {
	Console.WriteLine($"A senha digitada possui pelo menos caracteres");
} else {
	Console.WriteLine($"Senha com menos caracteres não é considerada segura");
}

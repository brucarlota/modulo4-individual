// Login simples

Dictionary<string, string> usuario = new()
{
    { "brunacruz", "123456senha" },
		{ "mariajose", "09876543haha" }
};

Console.Write("Digite usuário: ");
string userInput = Console.ReadLine()!;

if (!usuario.ContainsKey(userInput))
{
    Console.WriteLine("Usuário não encontrado.");
    return;
}

Console.Write("Digite senha: ");
string passwordInput = Console.ReadLine()!;

while (passwordInput != usuario[userInput]) {
	Console.Write("Senha errada! Tente novamente: ");
	passwordInput = Console.ReadLine()!;
}

if (passwordInput == usuario[userInput]) {
	Console.Write("Login Sucesso!!");
}

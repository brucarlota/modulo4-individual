// Exercicio 04 - Conversor de moedas

decimal valorReal;
Console.Write("Digite um valor em reais R$: ");
decimal.TryParse(Console.ReadLine(), out valorReal);

// error CS0664: Literal of type double cannot be implicitly converted to type 'decimal'; use an 'M' suffix to create a literal of this type
decimal COTACAO_DOLAR = 5.08m;

decimal valorDolar = valorReal / COTACAO_DOLAR;
Console.WriteLine($"{valorReal:F2} R$ corresponde a {valorDolar:F2} US$ - cotação em 08/08/2026");

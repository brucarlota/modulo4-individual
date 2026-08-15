// Caixa eletrônico

int valorSaque;
Console.Write("Digite o valor de saque: ");
int.TryParse(Console.ReadLine(), out valorSaque);

int notas100 = 0;
int notas50 = 0;
int notas20 = 0;
int notas10 = 0;
int notas5 = 0;
int notas2 = 0;

int resto = 0;

if (valorSaque >= 100){
	notas100 = valorSaque / 100;
	resto = valorSaque % 100;
} else {
	resto = valorSaque;
}

if (resto >= 50){
	notas50 = resto / 50;
	resto = resto % 50;
}

if (resto >= 20){
	notas20 = resto / 20;
	resto = resto % 20;
}

if (resto >= 10){
	notas10 = resto / 10;
	resto = resto % 10;
}

if (resto >= 5){
	notas5 = resto / 5;
	resto = resto % 5;
}

if (resto >= 2){
	notas2 = resto / 2;
	resto = resto % 2;
}

if (notas100 > 0) Console.WriteLine($"Notas de 100: {notas100}");
if (notas50 > 0) Console.WriteLine($"Notas de 50: {notas50}");
if (notas20 > 0) Console.WriteLine($"Notas de 20: {notas20}");
if (notas10 > 0) Console.WriteLine($"Notas de 10: {notas10}");
if (notas5 > 0) Console.WriteLine($"Notas de 5: {notas5}");
if (notas2 > 0) Console.WriteLine($"Notas de 2: {notas2}");

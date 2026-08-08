// Exercício 03 - Área de um retângulo

float baseNro;
float alturaNro;

Console.Write("Base: ");
float.TryParse(Console.ReadLine(), out baseNro);

Console.Write("Altura: ");
float.TryParse(Console.ReadLine(), out alturaNro);

float area = baseNro * alturaNro;
float perimetro = 2 * (baseNro + alturaNro);

Console.WriteLine($"Area: {area}");
Console.WriteLine($"Perímetro: {perimetro}");
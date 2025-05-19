using System;
using System.Globalization;
using TP3MarianoTorres;

Console.WriteLine("Ingrese los datos de la persona:");
Console.WriteLine("Nombre:");
string nombre = Console.ReadLine();
Console.WriteLine("Sueldo:");
decimal sueldo = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Sexo:");
string sexo = Console.ReadLine();
Console.WriteLine("Peso:");
int peso = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Altura:");
decimal altura = Convert.ToDecimal(Console.ReadLine());

Console.Clear();

Persona unaPersona = new(nombre, sueldo, sexo, peso, altura);

Console.WriteLine("Nueva persona creada en el sistema:");
Console.WriteLine($"Nombre: {unaPersona.Nombre}");
Console.WriteLine($"Email: {unaPersona.Email}");
Console.WriteLine($"Sueldo: {unaPersona.Sueldo} ARS");
Console.WriteLine($"Sexo: {unaPersona.Sexo}");
Console.WriteLine($"Peso: {unaPersona.Peso} kg(B)");
Console.WriteLine($"Altura: {(unaPersona.Altura).ToString(new CultureInfo("es-ES"))} m");

Console.ReadLine();
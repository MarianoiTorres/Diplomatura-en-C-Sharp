
using TP3MarianoTorres;

Console.WriteLine("Ingrese los datos de la persona:");
Console.WriteLine("Nombre:");
string nombre = Console.ReadLine();
Console.WriteLine("Sueldo:");
decimal sueldo = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Sexo:");
string sexo = Console.ReadLine();
Console.WriteLine("Peso:");
decimal peso = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Altura:");
decimal altura = Convert.ToDecimal(Console.ReadLine());

Console.Clear();

Persona unaPersona = new Persona(nombre, sueldo, sexo, peso, altura);

Console.WriteLine("Nueva persona creada en el sistema:");
Console.WriteLine($"Nombre: {unaPersona.GetNombre()}");
Console.WriteLine($"Email: {unaPersona.GetEmail()}");
Console.WriteLine($"Sueldo: {unaPersona.GetNombre()} ARS");
Console.WriteLine($"Sexo: {unaPersona.GetNombre()}");
Console.WriteLine($"Peso: {unaPersona.GetNombre()} kg(B)");
Console.WriteLine($"Altura: {unaPersona.GetAltura() / 100} m");

Console.ReadLine();
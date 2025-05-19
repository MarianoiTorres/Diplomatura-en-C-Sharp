// 3. Crear la función para el ejercicio 1 que se llame CalcularIVA, la cual debe recibir un parámetro de tipo numérico y devolver el valor Final con IVA.

using Ejercicio3;

Console.WriteLine("Ingrese el valor del producto:");
decimal productPrice = Convert.ToDecimal(Console.ReadLine());
decimal totalWithIVA = CalcularIVA.CalcularIva(productPrice);

Console.WriteLine($"Precio del producto: ${productPrice}");
Console.WriteLine($"IVA del producto: ${productPrice * 0.21m}");
Console.WriteLine($"Precio Total con IVA incluido: ${totalWithIVA}");

Console.ReadLine();
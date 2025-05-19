
Console.WriteLine("Ingrese el valor del producto:");
decimal productPrice = Convert.ToDecimal(Console.ReadLine());
decimal iva = productPrice * 0.21m;

Console.WriteLine($"Precio del producto: ${productPrice}");
Console.WriteLine($"IVA del producto: ${iva}");
Console.WriteLine($"Precio Total con IVA incluido: ${productPrice + iva}");

Console.ReadLine();
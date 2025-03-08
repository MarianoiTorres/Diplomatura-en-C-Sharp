//    1.Crea un programa que calcule el IVA de un producto. El valor de este producto se pasará por 
//    teclado y nos mostrará por pantalla el valor del IVA y su valor final. El IVA es el 21 %. 
//    Por ejemplo, si introducimos 100 como valor de producto, el IVA es 21 y el valor final es 121.
Console.WriteLine("Ingrese el valor del producto:");
decimal productPrice = Convert.ToDecimal(Console.ReadLine());
decimal iva = productPrice * 0.21m;

Console.WriteLine($"Precio del producto: ${productPrice}");
Console.WriteLine($"IVA del producto: ${iva}");
Console.WriteLine($"Precio Total con IVA incluido: ${productPrice + iva}");

Console.ReadLine();
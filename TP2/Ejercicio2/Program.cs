// 2. Crea un programa muestre los números entre el 0 y el 100, que no sean divisibles por 2. Usa un ciclo While.
int count = 0;

while(count != 101)
{
    if(!(count % 2 == 0))
    {
        Console.WriteLine($"Numero: {count}");
    }

    count += 1;
}
Console.ReadLine();
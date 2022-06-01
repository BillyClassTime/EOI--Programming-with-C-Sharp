/*string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
   if (names[i] == "David") names[i] = "Sammy";
}
foreach (var name in names) Console.WriteLine(name); 
Console.WriteLine("-");
int sizeArray = 0; // names.Length - 1;
foreach (var name in names) // va de 0 hasta el longitud de la matriz
{
    Console.WriteLine(name);
    if (names[sizeArray] == "Michael") {
        names[sizeArray] = "Miky";
        Console.WriteLine(name);
        Console.WriteLine(names[sizeArray]);
    }
    sizeArray ++;
}

int value = 1;
value++;
Console.WriteLine("First: " + value);
Console.WriteLine("Second: " + ++value);
Console.WriteLine("Third: " + value);
Console.WriteLine("Fourth: " + (++value));
*/
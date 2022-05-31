int i;
i= 0;
while(i<=100)
{
    i++;
    if (i>=10 || i<=20) // No se usa el || (o) se debe usar el && (y)
        continue;
    Console.WriteLine($"**:{i}");
} 

i=0;
do
{
    i++;
    if (i>=10 || i<=20)  // No se usa el || (o) se debe usar el && (y)
        continue;
    Console.WriteLine($"##:{i}");
} while (i<=100);
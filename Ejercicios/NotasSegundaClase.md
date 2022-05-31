### Instrucciones if y expresion booleanas

```c#
Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");


if (  (roll1 == roll2)  ||  (roll2 == roll3)  ||  (roll1 == roll3)  )
{
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
}

if (( roll1 == roll2) && (roll2 == roll3)) {
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total+=6;
}
if (total >= 15)
{
    Console.WriteLine("You win!");
}

if (total < 15)
{
    Console.WriteLine("Sorry, you lose.");
}
```



### IF else anidados

```c#
Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    }
    else {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}

if (total >= 16)
    Console.WriteLine("You win a new car!");
else if (total >=10)
    Console.WriteLine("You win a new laptop!");
else if (total ==7)
    Console.WriteLine("you win a trip");
else
    Console.WriteLine("you win a kitten") ; 

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here
Console.WriteLine($"Dias para la expiración:{daysUntilExpiration}");

if (daysUntilExpiration<=0)
    Console.WriteLine("Your subscription has expired.");
else if (daysUntilExpiration==1)
{
    discountPercentage = 20;
    Console.WriteLine(@"Your subscription expires within a day!
    Renew now and save {discountPercentage}%!"); 
}
else if (daysUntilExpiration<=5) 
{
    discountPercentage=10;
    Console.WriteLine($@"Your subscription expires in {daysUntilExpiration} days.
    Renew now and save {discountPercentage}%!");
}
else if (daysUntilExpiration<= 10)
    Console.WriteLine("Your subscription will expire soon. Renew now!");
```



###  Matrices en C#

```c#
string IdOrdenFraudulenta = "";

string[] IdOrdenesFraudulentas = new string[10];

int edad = 0;

int[] edades = new int[3];

bool opcion = true;

bool[] opciones = new bool[5];

// Matrices en C#
// Declaración
string[] IdOrdenesFraudulentas = new string[3];

IdOrdenesFraudulentas[0]="A123";
IdOrdenesFraudulentas[1]="B456";
IdOrdenesFraudulentas[2]="C789";

//IdOrdenesFraudulentas[3]="D012";

Console.WriteLine($"primero:{IdOrdenesFraudulentas[0]}");
Console.WriteLine($"segundo:{IdOrdenesFraudulentas[1]}");
Console.WriteLine($"tercero:{IdOrdenesFraudulentas[2]}");

IdOrdenesFraudulentas[0] = "F000";

Console.WriteLine($"Reassign First: {IdOrdenesFraudulentas[0]}");
// Matrices en C#
// Declaración
string[] IdOrdenesFraudulentas = new string[3];

string[] idOtrasOrdener = {"A123", "B456","C789","DIU8"};

Console.WriteLine($"Longitud primera matriz:{IdOrdenesFraudulentas.Length}");
Console.WriteLine($"Opcion 1 de declaración pos 1:{IdOrdenesFraudulentas[0]}");

IdOrdenesFraudulentas[0]="A123";
IdOrdenesFraudulentas[1]="B456";
IdOrdenesFraudulentas[2]="C789";

Console.WriteLine($"Opcion 1 de declaración pos 1:{IdOrdenesFraudulentas[0]}");

Console.WriteLine($"Opcion 1 de declaración pos 2:{idOtrasOrdener[0]}");

Console.WriteLine($"Longitud segunda matriz:{idOtrasOrdener.Length}");
```





### For each para recorrer una matriz

```c#
int[] inventory = { 200, 450, 700, 175, 250 };
int sum =0;
int bin =0;
foreach (int item in inventory)
{
    sum+=item;
    //Console.WriteLine(item);
    Console.WriteLine($"Posicion:{bin++} - {item} Acumulado: {sum}");
}
```



###  Desafio
``` c#
string[] listaPedidosSospechos = {"B123","C234","A345","C15","B177","G3003","C235","B179"};

//string[] listaPedidosSospechos1 = new string[8];

foreach (string pedido in listaPedidosSospechos) {
    if(pedido.StartsWith("B"))
    {
        Console.WriteLine(pedido);
    }
}

// Comentario general
// 
int[] edadPersonas =new int[200];
//string[] ciudadesEuropeas = new string[1000];
// TODO paso inicial de declariones
// TODO proceso de gestiones de las ciudades
/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/
Random random = new Random();
string[] orderIDs = new string[5];
for (int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue = random.Next(65, 70);   // ASCII letters A=65 through E=70
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");
    orderIDs[i] = prefix + suffix;
}
foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}

```



###  Desafio

```c#
/*  

Revertidor de cadenas y contador de letras (oes)
*/
string originalMessage  = "The quick brown fox jumps over the lazy dog.";
char[] charMessage = originalMessage .ToCharArray();
int letterCount  = 0;

Array.Reverse(charMessage);

foreach (char letter  in charMessage) 
{ 
    if (letter  == 'o') 
    { 
        letterCount ++; 
    }
}

string new_message = new String(charMessage);

Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {letterCount } times.");
```




Segundo Desafio

```c#
int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;


// Your code here to set result1
int result1 =  value1 / (int)  value2;  // int.TryParse() No vale porque convierte string
//result1 = value1 / Convert.ToInt32(value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2

decimal result2 = value2 / (decimal) value3;
//result2 =  value2 / Convert.ToDecimal(value3);
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
float result3 = value3 / value1; 
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

//Console.WriteLine(int.MaxValue);
//Console.WriteLine(decimal.MaxValue);
```



Solución:

```c#
int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

int result1 = Convert.ToInt32((decimal)value1 / value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
```



Sort y Reverse

```c#
string[] pallets = {"B14", "A11", "B12", "A13","D14", "F11", "G12", "C13"};

foreach(var item in pallets)
    Console.WriteLine(item);
Console.WriteLine("- despues del ordenamiento (Sort)");
Array.Sort(pallets);
foreach(var item in pallets)
    Console.WriteLine(item);

Array.Reverse(pallets);
Console.WriteLine("-después del reverse");
foreach(var item in pallets)
    Console.WriteLine(item);
```

Clear 

```c#
string[] pallets = {"B14", "A11", "B12", "A13","D14", "F11", "G12", "C13"};
Console.WriteLine("");

Console.WriteLine($"Before: {pallets[0]}");
Array.Clear(pallets, 0, 2);
if (pallets[0]==null) 
   Console.WriteLine("Es una cadena nula");
else {
    Console.WriteLine(pallets[0].ToLower());
    Console.WriteLine("Es una cadena vacia");
}
Console.WriteLine($"After: {pallets[0]}");

Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    if (pallet != null)
        Console.WriteLine(pallet.ToLower());
    Console.WriteLine($"-- {pallet}");
}

/*string lastName ;
lastName = null;

lastName = string.Empty;
lastName = "";*/


```



Resize

```c#
string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
int nuevo_tamaño = 6;
// Parametros en C# -> por valor o por referencia (ref) -> TODOS son por valor
Array.Resize(ref pallets, nuevo_tamaño);
// Parametros en C# -> entrada y salida (out) 
int i=0;
int.TryParse("1",out i); // El return es un bool

Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
nuevo_tamaño = 3;
Console.WriteLine("");
Array.Resize(ref pallets, nuevo_tamaño);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
```

ToCharArray, Split, Join

```c#
string value = "abc123";

char[] valueArray = value.ToCharArray();

char[] valueArray1 = {'a','-','b','-','c','-','1','-','2','-','3'};

Array.Reverse(valueArray);
//string result = new String(valueArray);

string result = String.Join(",", valueArray); // "3,2,1,c,b,a"

Console.WriteLine(result);

string[] items = result.Split(',');

foreach (string item in items)
{
    Console.WriteLine(item);
}
```

Desafio

```c#
string pangram = "The quick brown fox jumps over the lazy dog";

//ehT kciuq nworb xof spmuj revo eht yzal god
string[] silabas = pangram.Split(' ');

foreach (var silaba in silabas)
   {
       char[] silabaDeRevez = silaba.ToCharArray();
       Array.Reverse(silabaDeRevez);
       string silabaDeRevezString = new String(silabaDeRevez);
       Console.Write($"{silabaDeRevezString} ");
   }
//Array.Reverse(pangram);

//ehT kciuq nworb xof spmuj revo eht yzal god 
```

Version 2:

 ```c#
 string pangram = "The quick brown fox jumps over the lazy dog";
 
 //ehT kciuq nworb xof spmuj revo eht yzal god
 string[] silabas = pangram.Split(' ');
 string resultado = string.Empty;
 foreach (var silaba in silabas)
    {
        char[] silabaDeRevez = silaba.ToCharArray();
        Array.Reverse(silabaDeRevez);
        string silabaDeRevezString = new String(silabaDeRevez);
        resultado += silabaDeRevezString + " ";
    }
 Console.Write($"{resultado} ");
 //Array.Reverse(pangram);
 
 //ehT kciuq nworb xof spmuj revo eht yzal god 
 ```

Respuesta al desafio:

```c#
string pangram = "The quick brown fox jumps over the lazy dog";

string[] message = pangram.Split(' ');
string[] newMessage = new string[message.Length];

for (int i = 0; i < message.Length; i++)
{
    char[] letters = message[i].ToCharArray();
    Array.Reverse(letters);
    newMessage[i] = new string(letters);
}

string result = String.Join(" ", newMessage);
Console.WriteLine(result);
```

Desafio No. 2

```c#

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

// 1 - Pasar la cadena a una matriz (array) criterio de separación ","

// 2 - Recorrer la nueva matriz (Hacere un bucle)

// 3 - Comprobar cada elemento si empieza por "B"
// Your code here

string[] nuevaMatriz = orderStream.Split(','); // Paso 1


foreach(var item in nuevaMatriz)               // Paso 2
{
    /*if (item.StartsWith("B"))                  // Paso 3
        Console.WriteLine(item);*/
    if (item[0]=='B')
        Console.WriteLine(item);
}
```

Solución al desafio

```c#
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] items = orderStream.Split(',');

foreach (var item in items)
{
    if (item.StartsWith("B"))
    {
        Console.WriteLine(item);
    }
}
```

```c#
//Conceptos básicos del formato de cadenas
string first = "Hello";
string second = "World";
string result = string.Format("{0} {1} {0} {0}!", first, second);
Console.WriteLine(result);


Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {second} {first} {first}!");

decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");


decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement} units");
Console.WriteLine($"Measurement: {measurement:N} units");

Console.WriteLine($"Measurement: {measurement:N1} units");

decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax}");
Console.WriteLine($"Tax rate: {tax:P2}");
Console.WriteLine($"Tax rate: {tax:P3}");
```

Formato 

PadLef y PadRigth

```c#
int invoiceNumber = 1201;
decimal productMeasurement = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"   Measurement: {productMeasurement:N3} mg");
Console.WriteLine($"     Sub Total: {subtotal:C}");
Console.WriteLine($"           Tax: {taxPercentage:P2}");
Console.WriteLine($"     Total Due: {total:C}");

Console.WriteLine("-");
string input = "Pad this";
Console.WriteLine(input.PadLeft(12));
Console.WriteLine(input.PadRight(12));

Console.WriteLine(input.PadLeft(12, '-'));
Console.WriteLine(input.PadRight(12, '-'));

string paymentId = "769";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";

var formattedLine = paymentId.PadRight(6,'*');
formattedLine += payeeName.PadRight(24,'*');
formattedLine += paymentAmount.PadLeft(10,'^');
Console.WriteLine("[1234567890123456789012345678901234567890]");
Console.WriteLine($"[{formattedLine}]");
```



Desafio:

```c#
/*
Dear Mr. Jones,
As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.

Currently, you own 2,975,000.00 shares at a return of 12.75 %.

Our new product, Glorious Future offers a return of 13.13 %.  Given your current volume, your potential profit would be ¤63,000,000.00.

Here's a quick comparison:

Magic Yield         12.75 %   ¤55,000,000.00      
Glorious Future     13.13 %   ¤63,000,000.00 */

string customerName = "Mr. Jones";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here

Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.");
Console.WriteLine();
Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P2}");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit:C}");


Console.WriteLine("Here's a quick comparison:\n");
//Magic Yield         12.75 %   ¤55,000,000.00      
//Glorious Future     13.13 %   ¤63,000,000.00 
//string comparisonMessage = string.Format("{0}{1:P2}{2:C}",currentProduct,currentReturn,currentProfit);

// Your logic here
var comparisonMessage = currentProduct.PadRight(20) + (string.Format("{0:P2}",currentReturn)).PadRight(10) + (string.Format("{0:C}",currentProfit)).PadRight(20);
comparisonMessage += "\n"+newProduct.PadRight(20) + (string.Format("{0:P2}",newReturn)).PadRight(10) + (string.Format("{0:C}",newProfit)).PadRight(20);

Console.WriteLine(comparisonMessage);
```

Solución:

```c#
string customerName = "Mr. Jones";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

comparisonMessage = currentProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

Console.WriteLine(comparisonMessage);
```


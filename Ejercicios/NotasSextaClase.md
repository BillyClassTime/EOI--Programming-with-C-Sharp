### Tipos de datos por valor enteros con signo

```c#
Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

sbyte dato = -128;
Console.WriteLine(dato);
--dato;
Console.WriteLine(dato);

int dato_entero = int.MinValue;
Console.WriteLine(dato_entero);
--dato_entero;
Console.WriteLine(dato_entero);

```



Tipos de datos  valor enteros sin signo

```c#
Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");

Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

byte unbyte = byte.MinValue;
Console.WriteLine(unbyte);
--unbyte;
Console.WriteLine(unbyte);
unbyte = byte.MaxValue; //+ 100;
unbyte = byte.MinValue;
Console.WriteLine("Inicio del bucle de los bytes sin signo");
for (int i=0; i<400;i++)
  {
      unbyte ++;
      if (i>253)
        Console.WriteLine(unbyte);
      if (i == 300) 
         break;
  }

//Enteros  
//2147483647 Con signo Extra un bit para el signo
//4294967295 Sin Signo

//Long
// 9223372036854775807 con signo Extra un bit para el signo
//18446744073709551615 sin signo
```



### Tipos  de datos de punto flotante

```c#
// float y double optimizan su almacenamiento en memoria 

//                sacrifican la presición.

//float -> almacena sus valores en formato binario (base 2)

//double-> almacena sus valores en formato binario (base 2)

//         usar para representar valore de aproximación



// decimal es mas preciso y necesita mas memoria de almacenamiento

//decimal-> almacena sus valores en formato decimal(base 10)

//          usado para representar valores de precision.



Console.WriteLine("");

Console.WriteLine("Floating point types:");

Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");

Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");

Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");
```





### Tipos de datos de referencia

```c#
// Los tipos de referencia incluyen matrices, clases y cadenas.

int age = 0;                // tipo de datos por valor
int[] data;                 // tipo de datos por referencia

string firstName = "Billy"; // tipo de datos por referencia

data = new int[3];
data[0]=23;
Console.WriteLine(data[0]); // 23
Console.WriteLine(data[1]); // 0
Console.WriteLine(data[2]); // 0
```



###  Conversion de tipos de datos

```c#
//Primera pregunta: En la conversión hay una excepción
int first = 2;
string second = "4";
//int result = first + second;  // No deja la conversion implicita de string a int

string result = first + second; // Si deja la conversion implicita de int a string
Console.WriteLine(result);
//Tecnicas para convertir.
/*
Usar un método auxiliar en el tipo de datos.
Usar un método auxiliar en la variable.
Usar métodos de la clase "Convert".*/ 

// Segunda pregunta: Hay perdidas de datos en la conversión
// Conversion de ampliacion
// int -> decimal
int sueldo = 1230;
decimal nuevo_sueldo;  
nuevo_sueldo = sueldo;        // Aqui hay una conversión implicita de ampliación (int-> dec)

// conversión de restricción
// decimal -> int

nuevo_sueldo = 1800;          // Si pasamos de decimal a int puede haber perdida de datos en la conversión
sueldo = (int) nuevo_sueldo;  // ??? me invita a usar un cast ()

//Cómo saber si una conversión es de ampliación o de restricción
// Consultar la tabla: https://docs.microsoft.com/es-ES/dotnet/standard/base-types/conversion-tables
```



###  Conversion con TryParse()

```c#
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int edad = 49;

string numero = "1"; // Convertir la cadena "1" a 1.
edad = edad + (int) numero[0];// numero[0] representa el ASCII de 1 que es 49, el ASCII de < es 60
Console.WriteLine(numero[0]); 
Console.WriteLine(edad );

edad = 0;
bool edad_boolean = Convert.ToBoolean(edad);  // Tiene sentido??
Console.WriteLine(edad_boolean);

string first = "Y";
int sum = 0;
if (int.TryParse(first,out sum))  // La conversion ha sido posible
   Console.WriteLine($"Resultado:{sum}");
else
    Console.WriteLine("No ha sido posible la conversion");

first = "5";
sum = 0;
if (int.TryParse(first,out sum))  // La conversion ha sido posible
   Console.WriteLine($"Resultado:{sum}");
else
    Console.WriteLine("No ha sido posible la conversion");
first = "6"; // "W";
sum = int.Parse(first);  // Se usa si se tiene seguridad que la cadena tiene un valor convertible.
 Console.WriteLine($"Resultado 2:{sum}");
```



```c#
string value = "bad";
int result = 2;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}

// Since it is defined outside of the if statement, 
// it can be accessed later in your code.
//if (result > 0)
    Console.WriteLine($"Measurement (w/ offset): {50 + result}");
```

### Desafio

```c#
string[] values = { "12.3", "45", "ABC", "11", "DEF" };
string mensaje="";
decimal total=0;
foreach (string value in values)
{
    decimal result = 0;
    if (decimal.TryParse(value,out result))
        total += result;
    else
        mensaje += value;
}
Console.WriteLine($"Mensaje:{mensaje}");
Console.WriteLine($"Total:{total}");
```




### Concatenación e Interpolación de cadenas

```c#
string firstName = "Bob";
string greeting = "Hello";
//string message = ;
//Concatenar
Console.WriteLine(greeting + " " + firstName + "!");

//interpolar
Console.WriteLine($"{greeting} {firstName} !");

string projectName = "First - Project";

Console.WriteLine("C:\\Output\\" + projectName + "\\data");

// Combinación de literales textuales con interpolación
Console.WriteLine($@"C:\Output\{projectName}\data");
\q
\d
\'
```

### Desafio

```c#
string projectName = "ACME";

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";


Console.WriteLine($@"View English output:
     c:\Exercise\{projectName}\data.txt
     ");
//
Console.WriteLine($"{russianMessage}:\n\t c:\\Exercise\\{projectName}\\ru-RU\\data.txt");

// Basico de operadores
int firstNumber = 12;
int secondNumber =7;
string firstName = "Bob";

Console.WriteLine(firstName + " sold " + secondNumber + 7 + " widgets");
Console.WriteLine(firstName + "sold " + (secondNumber + 7) + " widgest");
```



### SobreCarga -> Algo haga mas de una acción 

```c#
/*

+ concatenar cadenas
+ suma valor numericos

*/
```



### Suma, resta multiplicación y resto

```c#
int sum = 7 + 5;
int difference = 7-5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine(sum);
Console.WriteLine(difference);
Console.WriteLine(product);
Console.WriteLine(quotient);

decimal decimalDivition = 7m / 5m; // Division entera si los dos numeros son enteros
Console.WriteLine(decimalDivition);

/*int restoDecimal = 5/ 7.0m ;         NO FUNCIONARA
Console.WriteLine(restoDecimal);*/ 

// division de enteros sin truncar Operador de conversión (cast)

int first = 7;
int second = 5;

decimal resultado = (decimal)first / (decimal)second;

Console.WriteLine(resultado);
```



### Uso del resto de la división tanto con enteros como decimales

```c#
int numeroUno = 200;
int numeroDos = 5;

Console.WriteLine(numeroUno % numeroDos);

decimal numeroTres = 7;
decimal numeroCuatro = 5;

Console.WriteLine(numeroTres % numeroCuatro);
/* PEMDAS para recordar el orden de operación en C#
Parentheses (paréntesis) (lo que se encuentra dentro del paréntesis se realiza primero)
Exponents (exponentes)
Multiplication (multiplicación) y Division (división) (de izquierda a derecha)
Addition (suma) y Subtraction (resta) (de izquierda a derecha)
*/

int value1 = 45 + 12 / 24 * 2 + 10 ; 
int value2 = 25 + 4 + (3 + 4) * 5;

Console.WriteLine(value1);
Console.WriteLine(value2);
```


### incremento y decremento

```c#
int value = 0;
value = value + 5;

Console.WriteLine(value);
value = value + 5;
Console.WriteLine(value);
//incrementa 5 a la variable value
value += 5;
Console.WriteLine(value);

//++ incremento de 1
value++;
Console.WriteLine(value);

//-- decremanta en 1
value--;
Console.WriteLine(value);

//decrementa 5 a la variable value
value -=5;
Console.WriteLine(value);

// Colocacion de los operadores de incremento y decremento ++ y --

int value = 1;

value ++; //incrementara a 1 la variable value (después)

++value; //incrementara a 1 la variable value (antes)
value = 1;
Console.WriteLine("Primero:" + value);
Console.WriteLine("Segundo:" + value++);
Console.WriteLine(value);

value = 1;
Console.WriteLine("-Primero:" + value);
Console.WriteLine("-Segundo:" + ++value);
Console.WriteLine(value);

value = 1;
Console.WriteLine("=Primero:" + value);
Console.WriteLine("=Segundo:" + (value++)); //después
Console.WriteLine(value);

value = 1;
Console.WriteLine("=>Primero:" + value);
Console.WriteLine("=>Segundo:" + (++value)); //antes MAS LEGIBLE
Console.WriteLine(value);


value = 4;
value *= 3;
Console.WriteLine("Multiplicacion:" + value);
```



###  llamado de metodos de clases en la biblioteca de .net

```c#
Random dice = new Random();
//int otrovariable = Random.Next(1,7); no es viable hay que instanciar un objeto de esta clase
int roll = dice.Next(1,7);
Console.WriteLine(roll);

// llamada a metodos de .net
var firstName = "Billy";
Random dice = new Random();
var rool = dice.Next(1,7);
// metodos que no devuelven valor VOID (nulos)

dice.Next()
```


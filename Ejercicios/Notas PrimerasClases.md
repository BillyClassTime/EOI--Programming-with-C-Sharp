### 1 - Ejercicios 

```c#
Console.WriteLine("hola mundo");
```

```c#
/*
Esta linea */

Console.WriteLine("hola mundo otra vez");

//Hasta aqui son un comentario

Console.WriteLine("Estas lineas anteriores estan comentadas");

Console.Write("Esto se escribe sin salto de linea");
Console.Write(" seguimos en la misma linea");
//\n
Console.WriteLine(" esto si se escribirá con salto de linea ");
Console.WriteLine("esto es otra linea");
/**/
```



### Desafio

```c#
Console.Write("This is");
Console.Write(" the first line");

Console.WriteLine();  // David Console.WriteLine(); //Ivan Write y this is line 5
Console.Write("This is the ");
Console.Write(" second line.");
```



### Tipos de datos en c#

```c#
// Tipo de datos string
Console.WriteLine("Hola mundo");

// Tipo de datos Char  (Un solo caracter)
Console.WriteLine('b');

//Console.WriteLine('Hola mundo'); Produce error por la comilla que se usa solo con caracteres

// Tipo de datos int (entero)
Console.WriteLine(123);

// Tipo de datos decimal 
Console.WriteLine(12.3m);
Console.WriteLine(12.3); // Esto también escribe un decimal pero usad el sufijo litera m o M
Console.WriteLine(12.3M);

// Tipo de datos Boolean
Console.WriteLine(true);
//Console.WriteLine(True); true es en minuscula lo mismo que false
Console.WriteLine(false);

Console.WriteLine("123");
Console.WriteLine(123);

Console.WriteLine("True");
Console.WriteLine(true);
```



###  Declarando Variables

```c#
// Declarando variables

/*string
char
int
decimal*/

string firstName;
firstName="";
Console.WriteLine(firstName);

//string while; Las variables no se pueden nombrar como palabras clave o reservadas del lenguaje
string temperaturasCiudad;

//Ejemplo de como NO NOMBRAR una variable
string tempCi;

char userOption;               //Declaramos una variable de tipo caracter
int gameScore;                 //Declaramos una variable de tipo entero
decimal particlesPerMillon;    //Declaramos una variable de tipo decimal
bool processedCustomer;        //Declaramos una variable de tipo bool (True o False)

userOption='b';
//Asignar valores y mostrarlos
string firstName;
firstName="Bob";
//"Bod" = firstName;
//int lastName;
//lastName = "Williams"; // Conversion de string a int y no la puede de forma implicita
Console.WriteLine(firstName);

firstName="Beth";
Console.WriteLine(firstName);
firstName="Conrad";
Console.WriteLine(firstName);
firstName="Grant";
Console.WriteLine(firstName);
firstName="Ligth";
Console.WriteLine(firstName);
```

### Uso de las variables despues de su asignación de valor

```c#
string firstName;               // Declaración
firstName="Bod";                //Asignación de valor obligatorio antes de su uso
Console.WriteLine(firstName);   //Uso de la variable

string lastName = "Williams";  // Declaración y asignación de valor inicial
                               //Asignación de valor obligatorio antes de su uso
Console.WriteLine(lastName);   //Uso de la variable

// Variables locales con tipo implícito
int age = 49;
Console.WriteLine(age);
var firstName = "Billy";
Console.WriteLine(firstName);

//var size = objeto_creado_de_una_clase.metodo("argumentox");
//decimal size; equivalente a la siguiente linea pero sin asignación
var size = 12.4m;
size = 23.2m;
//size = "peso ideal";
Console.WriteLine(size);
```



### Desafio

```c#
string name = "Bob";
int mensaje = 3;
decimal temperatura = 34.4m;

Console.Write("Hello, ");
Console.Write(name);
Console.Write("! you have ");
Console.Write(mensaje);
Console.Write(" in your inbox. The temperatura is ");
Console.Write(temperatura);
Console.Write(" celcius");
```

### Secuencias de escape

```c#
Console.WriteLine("Hola \n mundo");

/* char saltoDeLinea = '\n';
char tabulador = '\t';
string saltoDeLineaDos = "\n";
*/

Console.WriteLine("Hello \"World\"!");
Console.WriteLine("Hello 'World'!");
Console.WriteLine("C:\\Source\\Repos");

// Aplicación de secuencias de espace
Console.WriteLine("Generating invoices for customer \"ABC Corp\" ...\n");
//Console.WriteLine();
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
//Console.WriteLine();
Console.WriteLine("\nOutput Directory:\t");
Console.WriteLine(@"C:\Invoices");
/*
Console.WriteLine(@"  C:\Source\Respos igual a Estilo 
\t esto como lo imprime, respueta como el caracter \t  
\n y esto?? y sto como el caracter \n 
");
*/
// Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u3099 World!");

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
Console.WriteLine(@"c:\invoices\app.exe -j");
```












/*  Expresiones booleans
*Console.WriteLine("a" == "a");

Console.WriteLine("a" == "A");

string myValue  = "a";

Console.WriteLine(myValue == "a");

Console.WriteLine("a" == "a "); */

string value1= " a b";
string value2= "A ";

Console.WriteLine($"'{value1}'");
Console.WriteLine($"'{value1.Trim()}'");

Console.WriteLine($"17:-'{value1.Trim('b').ToLower()}'");
Console.WriteLine(value2.Trim().ToLower());
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

// > < <= >=

Console.WriteLine("a" != "a");


Console.WriteLine("a" != "A");

string myValue3 = "a";

Console.WriteLine(myValue3 != "a");

Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);

string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));

Console.WriteLine(pangram.EndsWith("."));

string cadena = "T";

Console.WriteLine(pangram.StartsWith("S"));

Console.WriteLine(pangram.StartsWith(cadena));

// Operacion de negacion !
string pangram = "The quick brown fox jumps over the lazy dog.";


Console.WriteLine(!pangram.Contains("sevilla"));

// Operador condicional
// <expresion>   ? ejecución por verdad  : ejecución por falsedad




int saleAmount = 1001;

//int discount = saleAmount > 1000 ? 100 : 50;

/*int discount;
if (saleAmount > 1000)
   discount = 100;
else
   discount = 50;*/

//Console.WriteLine($"Descuento:{discount}");

Console.WriteLine($"Descuento:{(saleAmount > 1000 ? 100:50)}");

// Desafio

Random coin = new Random();
int cara_cruz = coin.Next(2);
Console.WriteLine($"Moneda al aire:{cara_cruz}->{(cara_cruz== 0 ? "cara" : "cruz")}");

// Solución alternativa: Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails");

//Console.WriteLine($"Moneda al aire:{cara_cruz}->{"cara"} {"cruz"}");

//< expresion bool>  ? <true> : <false>


// Desafio II
string permiso_usuario2="Manager";
int nivel_usuario2=45;

string permiso_usuario3="Finanzas";
int nivel_usuario3=70;

    //Console.WriteLine(permission.Split('|')[0].Contains("Admin"));


string permission = "Admin|Manager";
int level = 55;

string permiso_usuario1="Manager";
int nivel_usuario1=10;

if (permission.Contains(permiso_usuario1))
    if (permiso_usuario1.Contains("Admin"))
            if (nivel_usuario1 > level)
                Console.WriteLine("Welcome, Super Admin user.");
            else
                Console.WriteLine("Welcome, Admin user.");
    else{
        if (nivel_usuario1>20)
            Console.WriteLine("Contact an Admin for access.");
        else
            Console.WriteLine("You do not have sufficient privileges");
    }
else
    Console.WriteLine("You do not have sufficient privileges.");
    




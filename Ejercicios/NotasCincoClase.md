### Switch 

```c#
int employeeLevel = 200;
int employeeLevel = 201;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
        title = "Junior Associate";
        break;
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");

int employeeLevel = 100;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");
```





### Cambiar a sentencias switch

```c#
// SKU = Stock Keeping Unit
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

if (product[0] == "01")
{
    type = "Sweat shirt";
} else if (product[0] == "02")
{
    type = "T-Shirt";
} else if (product[0] == "03")
{
    type = "Sweat pants";
}
else
{
    type = "Other";
}

if (product[1] == "BL")
{
    color = "Black";
} else if (product[1] == "MN")
{
    color = "Maroon";
} else
{
    color = "White";
}

if (product[2] == "S")
{
    size = "Small";
} else if (product[2] == "M")
{
    size = "Medium";
} else if (product[2] == "L")
{
    size = "Large";
} else
{
    size = "One Size Fits All";
}

Console.WriteLine($"Product: {size} {color} {type}");
```



### Sentencias for

All three sections (initializer, condition, and iterator) are optional. However, in practice, typically all three sections are used.

```c#
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
}
Uso del break;
int i=0;
for (;;){
    i++;
    Console.WriteLine(i);
    if (i == 10) break;
}
Iterando en una Matriz (array)
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}
string[] names = { "Alex", "Eddie", "David", "Michael" };
foreach (var name in names)
{
    // Can't do this:
    if (name == "David") name = "Sammy";
}
```



### Solucion al desafio: de bucles for

```c#
for (int i = 1; i < 101; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
        Console.WriteLine($"{i} - FizzBuzz");
    else if (i % 3 == 0)
        Console.WriteLine($"{i} - Fizz");
    else if (i % 5 == 0)
        Console.WriteLine($"{i} - Buzz");
    else
        Console.WriteLine($"{i}");
}

// SKU = Stock Keeping Unit
string sku = "01-MN-L";//"01" "MN"   "L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

if (product[0] == "01")
{
    type = "Sweat shirt";
} else if (product[0] == "02")
{
    type = "T-Shirt";
} else if (product[0] == "03")
{
    type = "Sweat pants";
}
else
{
    type = "Other";
}
/*
switch (product[0])
{
    case "01":
        type = "Sweat shirt"; 
        break;
    case "02":
        type = "T-Shirt";
        break;
    case "03":
        type = "Sweat pants";
        break;
    default:
        type = "Other";
        break;
}
switch(product[1]){
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    default:
        color = "White";
        break;
}*/
if (product[1] == "BL")
{
    color = "Black";
} else if (product[1] == "MN")
{
    color = "Maroon";
} else
{
    color = "White";
}
/*
switch (product[2])
{
case "S":
    size="Small";
    break;
case "M":
    size="Medium";
    break;
case "L":
    size="Large";
    break;
default:
    size = "One Size Fits All";
    break;
}*/
if (product[2] == "S")
{
    size = "Small";
} else if (product[2] == "M")
{
    size = "Medium";
} else if (product[2] == "L")
{
    size = "Large";
} else
{
    size = "One Size Fits All";
}

Console.WriteLine($"Product: {size} {color} {type}");
// SKU = Stock Keeping Unit
string sku = "01-MN-L";//"01" "MN"   "L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

if (product[0] == "01")
{
    type = "Sweat shirt";
} else if (product[0] == "02")
{
    type = "T-Shirt";
} else if (product[0] == "03")
{
    type = "Sweat pants";
}
else
{
    type = "Other";
}
/*
switch (product[0])
{
    case "01":
        type = "Sweat shirt"; 
        break;
    case "02":
        type = "T-Shirt";
        break;
    case "03":
        type = "Sweat pants";
        break;
    default:
        type = "Other";
        break;
}
switch(product[1]){
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    default:
        color = "White";
        break;
}*/
if (product[1] == "BL")
{
    color = "Black";
} else if (product[1] == "MN")
{
    color = "Maroon";
} else
{
    color = "White";
}
/*
switch (product[2])
{
case "S":
    size="Small";
    break;
case "M":
    size="Medium";
    break;
case "L":
    size="Large";
    break;
default:
    size = "One Size Fits All";
    break;
}*/
if (product[2] == "S")
{
    size = "Small";
} else if (product[2] == "M")
{
    size = "Medium";
} else if (product[2] == "L")
{
    size = "Large";
} else
{
    size = "One Size Fits All";
}

Console.WriteLine($"Product: {size} {color} {type}");
```



### Switch con rangos de valores

```c#
int size = 90;
string tipo = "";
switch (size)
{
    case int n when (n >= 0 && n <= 50):
        tipo = "pequeño";
        break;
    case int n when (n >= 51 && n <= 70):
        tipo = "mediano";
        break;
    case int n when (n >= 71 && n <= 120):
        tipo = "grande";
        break;
    default:
        tipo ="Tamaño no definido";
        break;
}

Console.WriteLine(tipo);
```



### Construcción For

```c#
int inicio=1;
bool codicion=true;
int stop = 100;

for (int i = 0; i<=10; i++)  // for incremental
{
  Console.WriteLine(i);
}
for (int i = 10; i>=0; i--) // for decremental
  Console.WriteLine(i);

int iteracion = 0;
for(;;)
{
    iteracion++;
    if (iteracion==10) break;
    Console.WriteLine(iteracion);
}

string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
   if (names[i] == "David") names[i] = "Sammy";
}
foreach (var name in names) Console.WriteLine(name); 
Console.WriteLine("-");
int sizeArray = 0;//names.Length - 1;
foreach (var name in names) 
{
    Console.WriteLine(name);
    if (names[sizeArray] == "Michael") {
        names[sizeArray] = "Miky";
        Console.WriteLine(name);
    }
    //sizeArray --;
    sizeArray ++;
}
```



### Bucles do while y while

```c#
int i = 0;
do
{
    Console.WriteLine(i);
    i++;
} while(i<=10);
Console.WriteLine($"Valor de i:{i}");
Console.WriteLine("-");
Random random = new Random();
int current = 0;

do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);

current = random.Next(1, 11);

/*
do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);
*/
Console.WriteLine("-");
while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");

//int i;
i= 0;
while(i<=100)
{
    i++;
    if (i>=10 && i<=20) // No se usa el || (o) se debe usar el && (y)
        continue;
    Console.WriteLine($"**:{i}");
} 

i=0;
do
{
    i++;
    if (i>=10 && i<=20)  // No se usa el || (o) se debe usar el && (y)
        continue;
    Console.WriteLine($"##:{i}");
} while (i<=100);
```



### Desafio

```c#
// Desafio
// Cumpliendo la regla 1
int saludHeroe = 10;
int saludMonstruo = 10;

//Cumpliendo la regla 2
Random controlAtaques = new Random();
//controlAtaques.Next(1,10);
int daño = 0;


bool ControlMaster=true;

while(ControlMaster)
{
    //turno del heroe (regla 3)
        //control de salud para saber si salimos del turno del heroe
        daño = controlAtaques.Next(1,10);
        saludMonstruo = saludMonstruo - daño;
        Console.WriteLine($"Monster was damaged and lost: {daño} health and now has {saludMonstruo} health"); 
    if (saludMonstruo>0) {
        daño = controlAtaques.Next(1,10);
        saludHeroe = saludHeroe - daño;
        Console.WriteLine($"Hero was damaged and lost:{daño} health and now has {saludHeroe} health"); 
    }
    //controlamos la salud del monstruo y del heroe<0
    //                finalizamos el control master = false
    if (saludHeroe<=0) {
        Console.WriteLine("Monsters wins!");
        ControlMaster = false;
    }
    if (saludMonstruo<=0) {
        Console.WriteLine("Hero wins!");
        ControlMaster = false;
    }
    //if (saludMonstruo<=0 || saludHeroe <=0)
    //   ControlMaster=false;
}
```



###  Solucion al desafio

```c#
int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

if (monster <= 0) continue;
    
    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
```

#### Version: alternativa

```c#
int saludHeroe=10;
int saludMonstruo=10;

Random ControlAtaques=new Random();
int daño=0;
int cont=1;
bool ControlMaster=true;

while(ControlMaster){
    Console.WriteLine($"Turno {cont}");
    daño=ControlAtaques.Next(1,10);
    saludMonstruo=saludMonstruo-daño;
    Console.WriteLine("Ataca el Heroe");
    Console.WriteLine($"El Heroe ha golpeado inflinge {daño} de daño!!");
    Console.WriteLine($"Al Monstruo le queda {saludMonstruo} de salud restante!!");
    cont++;
    if(saludMonstruo>0){
       Console.WriteLine($"Turno {cont}");
       daño=ControlAtaques.Next(1,10);
       saludHeroe=saludHeroe-daño;
       Console.WriteLine("Ataca el Monstruo");
       Console.WriteLine($"El Monstruo ha golpeado inflinge {daño} de daño!!");
       Console.WriteLine($"Al Heroe le queda {saludHeroe} de salud restante!!");
       cont++;
    }        
    if(saludHeroe<=0){
       Console.WriteLine("El Heroe ha muerto Monstruo ha ganado!!");
    }
    if(saludMonstruo<=0){
       Console.WriteLine("El Monstruo ha muerto Heroe ha ganado!!");
    }
    if(saludHeroe<=0 || saludMonstruo<=0){
       ControlMaster=false;
    }   
}
```





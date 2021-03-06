# Trabajo con archivos y directorios en una aplicaci贸n .NET



### NameSpace

```c#
using System.IO;
```

## Enumeraci贸n de todos los directorios

``` 
馃搨 stores
    馃搫 sales.json
    馃搫 totals.txt
    馃搨 201
       馃搫 sales.json
       馃搫 salestotals.json
       馃搫 inventory.txt
    馃搨 202
```

```c#
IEnumerable<string> listOfDirectories = Directory.EnumerateDirectories("stores");

foreach (var dir in listOfDirectories) {
    Console.WriteLine(dir);
}

```

## Enumeraci贸n de los archivos de un directorio espec铆fico

```c#
IEnumerable<string> files = Directory.EnumerateFiles("stores");

foreach (var file in files)
{
    Console.WriteLine(file);
}

// Outputs:
// stores/totals.txt
// stores/sales.json
```

## Enumeraci贸n de todo el contenido de un directorio y todos los subdirectorios

```c#
// Find all *.txt files in the stores folder and its subfolders
IEnumerable<string> allFilesInAllFolders = Directory.EnumerateFiles("stores", "*.txt", SearchOption.AllDirectories);

foreach (var file in allFilesInAllFolders)
{
    Console.WriteLine(file);
}

// Outputs:
// stores/totals.txt
// stores/201/inventory.txt
```

# Ejercicio: Trabajar con el sistema de archivos

[Ejercicio: Trabajar con el sistema de archivos - Learn | Microsoft Docs](https://docs.microsoft.com/es-es/learn/modules/dotnet-files/3-exercise-file-system)

```powershell
dotnet --list-sdks
```



## Clonaci贸n del proyecto

```powershell
git clone https://github.com/MicrosoftDocs/mslearn-dotnet-files && cd mslearn-dotnet-files
```

```powershell
dotnet new console -f net6.0 -n mslearn-dotnet-files -o .
```

## B煤squeda de los archivos sales.json

Las tareas siguientes crear谩n un programa para buscar todos los archivos sales.json en todas las carpetas del proyecto `mslearn-dotnet-files`.

### Inclusi贸n del espacio de nombres System.IO

``` c#
using System.IO;
using System.Collections.Generic;
```

```c#
IEnumerable<string> FindFiles(string folderName)
{
    List<string> salesFiles = new List<string>();

    var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

    foreach (var file in foundFiles)
    {
        // The file name will contain the full path, so only check the end of it
        if (file.EndsWith("sales.json"))
        {
            salesFiles.Add(file);
        }
    }

    return salesFiles;
}
```

```c#
var salesFiles = FindFiles("stores");

foreach (var file in salesFiles)
{
    Console.WriteLine(file);
}
```

## Ejecuci贸n del programa

```
dotnet run
```



# Trabajo con rutas de acceso de archivo en .NET

`System.IO` y el tipo `System.Environment` ayudar谩n a hacer que sus programa sean m谩s inteligentes y resistentes.

## Distinci贸n del directorio actual

```c#
Console.WriteLine(Directory.GetCurrentDirectory());
```

```
馃搨 stores
    馃搨 201
```

## Trabajo con directorios especiales

El c贸digo siguiente devuelve la ruta equivalente de la carpeta *Mis documentos* de Windows o el directorio *HOME* del usuario para cualquier sistema operativo, aunque el c贸digo se ejecute en Linux.

```c#
string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
```

## Trabajo con rutas de acceso

La clase `Path` se encuentra en el espacio de nombres `System.IO` de .NET

### Caracteres especiales de las rutas de acceso

Por ejemplo, Windows usa la barra diagonal inversa (`stores\201`), y macOS usa la barra diagonal (`stores/201`).

Para ayudarle a usar el car谩cter correcto, la clase `Path` contiene el campo `DirectorySeparatorChar`.

```c#
Console.WriteLine($"stores{Path.DirectorySeparatorChar}201");

// returns:
// stores\201 on Windows
//
// stores/201 on macOS
```

### Rutas de combinaci贸n

```c#
Console.WriteLine(Path.Combine("stores","201")); // outputs: stores/201
```

Recuerde que tendr铆a que usar la clase `Path.Combine` o `Path.DirectorySeparatorChar` en lugar de cadenas codificadas de forma r铆gida porque el programa podr铆a ejecutarse en muchos sistemas operativos diferentes. 

### Determinaci贸n de extensiones de nombre de archivo

```c#
Console.WriteLine(Path.GetExtension("sales.json")); // outputs: .json
```

### Obtenci贸n de todo lo que es necesario saber sobre un archivo o ruta de acceso

La clase `Path` contiene muchos m茅todos diferentes que realizan diversas acciones. Si quiere obtener el m谩ximo de informaci贸n posible sobre un directorio o un archivo, use la clase `DirectoryInfo` o `FileInfo`, respectivamente.

```c#
string fileName = $"stores{Path.DirectorySeparatorChar}201{Path.DirectorySeparatorChar}sales{Path.DirectorySeparatorChar}sales.json";

FileInfo info = new FileInfo(fileName);

Console.WriteLine($"Full Name: {info.FullName}{Environment.NewLine}Directory: {info.Directory}{Environment.NewLine}Extension: {info.Extension}{Environment.NewLine}Create Date: {info.CreationTime}"); // And many more
```

# Ejercicio: Trabajar con rutas

[Ejercicio: Trabajar con rutas - Learn | Microsoft Docs](https://docs.microsoft.com/es-es/learn/modules/dotnet-files/5-exercise-paths)

## Uso del directorio actual y combinaci贸n de rutas de acceso

```c#
var currentDirectory = Directory.GetCurrentDirectory();
```

```c#
var storesDirectory = Path.Combine(currentDirectory, "stores");
```

```c#
var salesFiles = FindFiles(storesDirectory);
```

```c#
var currentDirectory = Directory.GetCurrentDirectory();
var storesDirectory = Path.Combine(currentDirectory, "stores");
var salesFiles = FindFiles(storesDirectory);

foreach (var file in salesFiles)
{
    Console.WriteLine(file);
}
```

```powershell
dotnet run
```

## B煤squeda de todos los archivos .json

En el bucle `foreach` de `foundFiles`:

```c#
var extension = Path.GetExtension(file);
```

Cambie la instrucci贸n `if` 

```c#
if (extension == ".json")
```

Resultado:

```c#
foreach (var file in foundFiles)
{
    var extension = Path.GetExtension(file);
    if (extension == ".json")
    {
        salesFiles.Add(file);
    }
}
```

```powershell
dotnet run
```

# Creaci贸n de archivos y directorios

Usar las clases `Directory` y `File` para crear directorios y archivos

## Crear directorios

```c#
Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "stores","201","newDir"));
```

## Garant铆a de que los directorios existen

```c#
bool doesDirectoryExist = Directory.Exists(filePath);
```

## Creaci贸n de archivos

```c#
File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), "greeting.txt"), "Hello World!");
```

# Ejercicio: Crear archivos y directorios

[Ejercicio: Crear archivos y directorios - Learn | Microsoft Docs](https://docs.microsoft.com/es-es/learn/modules/dotnet-files/7-exercise-create-files-directories)

## Creaci贸n del directorio salesTotals

1 . Comente el bucle al final del codigo que muestra el resultado del FindFiles

2 . Cree las lineas para creaci贸n de directorios antes de llamar a FindFiles.

```c#
var salesTotalDir = Path.Combine(currentDirectory, "salesTotalDir");
Directory.CreateDirectory(salesTotalDir);   // Add this line of code

```

## Escritura del archivo totals.txt

C贸digo para crear un archivo vac铆o denominado *totals.txt* en el directorio *salesTotalsDir*, despu茅s de FindFiles:

```c#
File.WriteAllText(Path.Combine(salesTotalDir, "totals.txt"), String.Empty);
```

```powershell
dotnet run
```

# Lectura y escritura en archivos

Usar la clase `File` para leer archivos y escribir en ellos.

## Lectura de datos de archivos

Los archivos se leen a trav茅s del m茅todo `ReadAllText` de la clase `File`.

```c#
File.ReadAllText($"stores{Path.DirectorySeparatorChar}201{Path.DirectorySeparatorChar}sales.json");
```

El objeto que se devuelve de `ReadAllText` es una cadena.

```json
{
  "total": 22385.32
}
```

## An谩lisis de datos en archivos

Analizar archivos JSON con .NET

Agregue el paquete *Json.NET* al proyecto mediante NuGet.

```powershell
dotnet add package Newtonsoft.Json
```

Referencie en el programa:

```c#
using Newtonsoft.Json;
```



Y use el m茅todo `JsonConvert.DeserializeObject`:

```c#
var salesJson = File.ReadAllText($"stores{Path.DirectorySeparatorChar}201{Path.DirectorySeparatorChar}sales.json");
var salesData = JsonConvert.DeserializeObject<SalesTotal>(salesJson);

Console.WriteLine(salesData.Total);

class SalesTotal
{
  public double Total { get; set; }
}
```

## Escritura de datos en archivos

Uso del m茅todo `WriteAllText`

```c#
var data = JsonConvert.DeserializeObject<SalesTotal>(salesJson);

File.WriteAllText($"salesTotalDir{Path.DirectorySeparatorChar}totals.txt", data.Total.ToString());

// totals.txt
// 22385.32
```

### Anexi贸n de datos en archivos

Anexar datos con el m茅todo `File.AppendAllText`

```c#
var data = JsonConvert.DeserializeObject<SalesTotal>(salesJson);

File.AppendAllText($"salesTotalDir{Path.DirectorySeparatorChar}totals.txt", $"{data.Total}{Environment.NewLine}");

// totals.txt
// 22385.32
// 22385.32
```

# Ejercicio: Lectura de archivos y escritura en ellos

[Ejercicio: Lectura de archivos y escritura en ellos - Learn | Microsoft Docs](https://docs.microsoft.com/es-es/learn/modules/dotnet-files/9-exercise-read-write-files)

## Adici贸n de Json.NET al proyecto

```powershell
dotnet add package Newtonsoft.Json
```

## Preparaci贸n para los datos de ventas

En`Program.cs`, agregue `using Newtonsoft.Json`

```
using Newtonsoft.Json;
```

Debajo del m茅todo `FindFiles`, [agregue un nuevo `record`](https://docs.microsoft.com/es-ES/dotnet/csharp/language-reference/builtin-types/record/) que modelar谩 los datos de *sales.json*.

```c#
record SalesData (double Total);
```

## Creaci贸n de un m茅todo para calcular totales de ventas

Funci贸n que calcular谩 el total de ventas

```c#
double CalculateSalesTotal(IEnumerable<string> salesFiles)
{
    double salesTotal = 0;

    // READ FILES LOOP

    return salesTotal;
}
```

Bucle que itere en `salesFiles`, lea el archivo, analice el contenido como JSON y, tras ello, aumente la variable `salesTotal` con el valor `total` del archivo.

```c#
double CalculateSalesTotal(IEnumerable<string> salesFiles)
{
    double salesTotal = 0;

    // Loop over each file path in salesFiles
    foreach (var file in salesFiles)
    {      
        // Read the contents of the file
        string salesJson = File.ReadAllText(file);

        // Parse the contents as JSON
        SalesData? data = JsonConvert.DeserializeObject<SalesData?>(salesJson);

        // Add the amount found in the Total field to the salesTotal variable
        salesTotal += data?.Total ?? 0;
    }

    return salesTotal;
}
```

## Llamada al m茅todo CalculateSalesTotals

```c#
var currentDirectory = Directory.GetCurrentDirectory();
var storesDir = Path.Combine(currentDirectory, "stores");

var salesTotalDir = Path.Combine(currentDirectory, "salesTotalDir");
Directory.CreateDirectory(salesTotalDir);

var salesFiles = FindFiles(storesDir);

var salesTotal = CalculateSalesTotal(salesFiles); // Add this line of code

File.WriteAllText(Path.Combine(salesTotalDir, "totals.txt"), String.Empty);
```

## Escritura del total en el archivo totals.txt

Modifique el bloque `File.WriteAllText` para escribir el valor de la variable `salesTotal` en el archivo *totals.txt*. Durante el proceso, cambie la llamada `File.WriteAllText` a `File.AppendAllText` para que no se sobrescriba nada en el archivo.

```c#
var currentDirectory = Directory.GetCurrentDirectory();            
var storesDir = Path.Combine(currentDirectory, "stores");

var salesTotalDir = Path.Combine(currentDirectory, "salesTotalDir");
Directory.CreateDirectory(salesTotalDir);            

var salesFiles = FindFiles(storesDir);

var salesTotal = CalculateSalesTotal(salesFiles);

File.AppendAllText(Path.Combine(salesTotalDir, "totals.txt"), $"{salesTotal}{Environment.NewLine}");
```

## Ejecuci贸n del programa

```powershell
dotnet run
```



# Resumen

隆Enhorabuena! Ha completado este m贸dulo de Learn y ya sabe c贸mo trabajar con archivos y directorios en .NET.

En este m贸dulo, hemos aprendido a leer archivos y directorios, a crear archivos y directorios y a escribir datos en archivos. Nuestro c贸digo se ejecutar谩 en un entorno de producci贸n ficticio, en la empresa falsa m谩s grande de Internet.

Estos son algunos aspectos que deberemos tener en cuenta en este m贸dulo:

- `Directory.EnumerateDirectories` y `Directory.EnumerateFiles` aceptan un par谩metro que permite especificar una condici贸n de b煤squeda para los nombres que se van a devolver y un par谩metro para recorrer de forma recursiva todos los directorios secundarios.
- `System.Environment.SpecialFolder` es una enumeraci贸n que le permite acceder a carpetas definidas por el sistema, como el perfil de usuario o de escritorio, de una manera multiplataforma sin tener que memorizar la ruta de acceso exacta de cada sistema operativo.
- En caso de que sea necesario analizar otros tipos de archivo, consulte los paquetes disponibles en nuget.org. Por ejemplo, puede usar el paquete [CsvHelper](https://www.nuget.org/packages/CsvHelper) para los archivos .csv.
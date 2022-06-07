# Creación de una API web con controladores de ASP.NET Core

Crear un servicio RESTful multiplataforma mediante controladores de la API web de ASP.NET Core con .NET y C#.

### Escenario

Desarrollar un servicio RESTful de administración del inventario de pizzas como requisito previo para el escaparate web y la aplicación móvil de la empresa. El servicio debe permitir la adición, visualización, modificación y eliminación de tipos de pizzas; un uso estandarizado de los verbos de acción HTTP más conocidos como *crear, leer, actualizar y eliminar* (CRUD).

### ¿Qué hará?

En este módulo va a crear una nueva aplicación de API web con ASP.NET Core y va a aprender a ejecutarla y probarla desde la línea de comandos. Luego va a agregar un almacén de datos y un nuevo controlador de API. Por último, va a implementar y probar los métodos de API para crear, leer, actualizar y eliminar pizzas del almacén de datos.

### ¿Cuál es el objetivo principal?

Al final de esta sesión, podrá crear nuevas aplicaciones de API web mediante ASP.NET Core. También sabrá cómo crear controladores de API que implementen lógica CRUD básica.

# REST de ASP.NET Core

## REST: un patrón común para compilar API con HTTP

Transferencia de estado representacional (REST) es un estilo arquitectónico para compilar servicios web. Las solicitudes REST se realizan a través de HTTP. Usan los mismos verbos HTTP que usan los exploradores web para recuperar páginas web y enviar datos a los servidores. Los verbos son:

- `GET`: Recuperar datos del servicio web.
- `POST`: Crear un nuevo elemento de datos en el servicio web.
- `PUT`: Actualizar un elemento de datos en el servicio web.
- `PATCH`: Actualizar un elemento de datos en el servicio web describiendo un conjunto de instrucciones sobre cómo se debe modificar el elemento. La aplicación de ejemplo de este módulo no usa este verbo.
- `DELETE`: Eliminar un elemento de datos en el servicio web.

Las API de servicio web que se adhieren a REST se denominan API de RESTful. Se definen a través de:

- Identificador URI base.
- Métodos HTTP, como `GET`, `POST`, `PUT`, `PATCH` o `DELETE`.
- Un tipo de medio para los datos, como notación de objetos JavaScript (JSON) o XML.

## Ventajas de crear API en ASP.NET Core

- **Serialización simple**
- **Autenticación y autorización**
- **Enrutamiento junto con el código** 
- **HTTPS predeterminado** 

### Uso compartido de código y conocimientos con aplicaciones .NET

## Prueba de API web mediante .NET HTTP REPL

[Test web APIs with the HttpRepl | Microsoft Docs](https://docs.microsoft.com/en-us/aspnet/core/web-api/http-repl/?view=aspnetcore-6.0&tabs=windows)

```powershell
dotnet tool install -g Microsoft.dotnet-httprepl
```

```powershell
httprepl
```

# Ejercicio: Creación de un proyecto de API web

## Creación y exploración de un proyecto de API web

Crear una carpeta con el nombre **ContosoPizza**

Crear el proyecto de apiRest

```powershell
dotnet new webapi -f net6.0
```

Examinar los archivos y directorios siguientes:

| Nombre                | Descripción                                                  |
| :-------------------- | :----------------------------------------------------------- |
| *Controllers/*        | Contiene clases con métodos públicos expuestos como puntos de conexión HTTP. |
| *Program.cs*          | Configura los servicios y la canalización de solicitudes HTTP de la aplicación, y contiene el punto de entrada administrado de la aplicación. |
| *ContosoPizza.csproj* | Contiene los metadatos de configuración del proyecto.        |

## Compilación y prueba de la API web

```powershell
dotnet run
```

Abrir un explorador web e ir a:

```powershell
https://localhost:{PORT}/weatherforecast
```

Instalar HTTPREPL si no lo tiene instalado: (Abrir otra terminal)

```powershell
dotnet tool install -g Microsoft.dotnet-httprepl
```

Conectarse a la URL de APIRest: 

```powershell
httprepl https://localhost:{PORT}
```

Explorar:

```
ls
cd WeatherForecast
get

```

Salir de HTTPRepl:

```
exit
```

# Controladores de API web de ASP.NET Core

Echar un vistazo 

```c#
using Microsoft.AspNetCore.Mvc;

namespace ContosoPizza.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
```

## La clase base: `ControllerBase`

## Atributos de la clase API Controller

## Generación de resultados meteorológicos con el método `Get()`

# Ejercicio: Adición de un almacén de datos

[Ejercicio: Adición de un almacén de datos - Learn | Microsoft Docs](https://docs.microsoft.com/es-es/learn/modules/build-web-api-aspnet-core/5-exercise-add-data-store)

## Creación de un modelo de pizza

```
mkdir Models
```

Agreagar el código en un nuevo fichero

```c#
namespace ContosoPizza.Models;

public class Pizza
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool IsGlutenFree { get; set; }
}
```

# Ejercicio: Adición de un controlador



## Creación de un controlador

Agregar el siguiente código:

```c#

using ContosoPizza.Models;
using ContosoPizza.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContosoPizza.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaController : ControllerBase
{
    public PizzaController()
    {
    }

    // GET all action

    // GET by Id action

    // POST action

    // PUT action

    // DELETE action
}
```

## Obtención de todas las pizzas

```c#
[HttpGet]
public ActionResult<List<Pizza>> GetAll() =>
    PizzaService.GetAll();
```

## Recuperación de una única pizza

```c#
[HttpGet("{id}")]
public ActionResult<Pizza> Get(int id)
{
    var pizza = PizzaService.Get(id);

    if(pizza == null)
        return NotFound();

    return pizza;
}
```

## Compilación y prueba del controlador

```
dotnet run
```

```
httprepl https://localhost:{PORT}
ls
cd Pizza
get
get 1
get 5
```



# Acciones CRUD de ASP.NET Core

| Verbo de acción HTTP | Operación CRUD | Atributo de ASP.NET Core |
| :------------------- | :------------- | :----------------------- |
| `GET`                | Lectura        | `[HttpGet]`              |
| `POST`               | Crear          | `[HttpPost]`             |
| `PUT`                | Actualizar     | `[HttpPut]`              |
| `DELETE`             | Eliminar       | `[HttpDelete]`           |

## POST

```c#
[HttpPost]
public IActionResult Create(Pizza pizza)
{            
    // This code will save the pizza and return a result
}
```

## PUT

```c#
[HttpPut("{id}")]
public IActionResult Update(int id, Pizza pizza)
{
    // This code will update the pizza and return a result
}
```

## DELETE

```c#
[HttpDelete("{id}")]
public IActionResult Delete(int id)
{
    // This code will delete the pizza and return a result
}
```

# Ejercicio: Implementación de operaciones CRUD

Vamos a seguir ampliando el controlador de API web para agregar la capacidad de crear (`POST`), actualizar (`PUT`) y eliminar (`DELETE`) pizzas en el inventario.

## Incorporación de una pizza

Método `POST`

```c#
[HttpPost]
public IActionResult Create(Pizza pizza)
{            
    PizzaService.Add(pizza);
    return CreatedAtAction(nameof(Create), new { id = pizza.Id }, pizza);
}
```

## Modificación de una pizza

Método `PUT`

```c#
[HttpPut("{id}")]
public IActionResult Update(int id, Pizza pizza)
{
    if (id != pizza.Id)
        return BadRequest();
           
    var existingPizza = PizzaService.Get(id);
    if(existingPizza is null)
        return NotFound();
   
    PizzaService.Update(pizza);           
   
    return NoContent();
}
```

## Eliminación de una pizza

Método `DELETE`.

```c#
[HttpDelete("{id}")]
public IActionResult Delete(int id)
{
    var pizza = PizzaService.Get(id);
   
    if (pizza is null)
        return NotFound();
       
    PizzaService.Delete(id);
   
    return NoContent();
}
```

## Compilación y ejecución de la API web terminada

```
dotnet run
```

```
httprepl https://localhost:{PORT}
cd Pizza
ls

```

Realizar una solicitud `POST`

```
post -c "{"name":"Hawaii", "isGlutenFree":false}"
```



Realizar una solicitud `PUT`

```
put 3 -c  "{"id": 3, "name":"Hawaiian", "isGlutenFree":false}"
```

Ejecutar la acción `GET`

```
get
get 3
```

Realizar la acción `DELETE`

```
delete 3
get
```



# Resumen

En este módulo, se ha creado una API web de ASP.NET Core que se ejecuta en .NET. La API web crea, lee, actualiza y elimina pizzas desde una caché en memoria.

Ha aprendido que la creación de una API web ASP.NET Core implica lo siguiente:

1. Creación de una nueva aplicación mediante la plantilla *API web de ASP.NET Core*.
2. Creación de clases que heredan de la clase `ControllerBase` y que contienen métodos que responden a solicitudes HTTP.

Dado que este patrón permite centrarse en una sola acción de controlador a la vez, con un poco de práctica es posible crear API web funcionales con bastante rapidez.

En este módulo se ha usado una caché en memoria. Este enfoque le ha ayudado a centrarse en el aprendizaje de conceptos de API web, pero tiene algunas limitaciones obvias para las aplicaciones del mundo real. Si la aplicación se detiene, se pierden todos los cambios.

En una aplicación real se recomienda almacenar los datos en una memoria auxiliar, como una base de datos. Puede aprender a conservar y recuperar datos relacionales mediante Entity Framework Core en [este tutorial](https://docs.microsoft.com/es-ES/learn/modules/persist-data-ef-core/).




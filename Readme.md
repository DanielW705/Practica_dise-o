# Practica final de la clase de diseño

Lista de que haceres:

- [X] Creacion, enlazado y conexion a la base de datos.
- [ ] Creacion del login y de la pagina principal.
- [ ] Creacion de la pagina principal para ver los productos.
- [ ] Creacion de la vista para el inventario.
- [ ] Creacion del carrito de compras.

Comandos para usarlo (Ubuntu 22.0.0), teniendo en consideracion que ya se tiene instalado dotnet 7.0 con Sdk y runtime.

- Ver Sdk y runtime instalados:

``````
/* Ver todos los complementos instalados */
dotnet --info

/* Ver todos los SDKs instalados */

dotnet --list-sdks

/* Ver los runtime instalados */

dotnet --list-runtimes  
``````

- Paquetes nuget instalados:

```
/* Microsoft entity framework core */

dotnet add package Microsoft.EntityFrameworkCore --version 7.0.13

/* Microsoft entity framework core design */

dotnet add package Microsoft.EntityFrameworkCore.Design --version 7.0.13

/* Mysql EntityFramework */

dotnet add package MySql.EntityFrameworkCore --version 7.0.10

/* Entity framework manera global */

dotnet tool install --global dotnet-ef

```

- Comandos utilizados:

```
/* Ver paquetes instalados */

dotnet list package

/* Revisar si entity framework esta instalado */

dotnet ef

/* Leer la base de datos */

dotnet ef dbcontext scaffold "Server=<IP>;PORT=<Puerto> ;Database=TIENDA;Uid=Daniel;Pwd=123;" Mysql.EntityFrameworkCore -o Models -f -d --no-onconfiguring

/* Compilar proyecto */

dotnet build

/* Correr programa */

dotnet run

/* Publicar programa para servicio */

sudo dotnet publish -o <Ruta del servicio>

/* Recuerde reiniciar el servicio */

```
[Mas informacion de comandos dotnet](https://learn.microsoft.com/en-us/ef/core/cli/dotnet)

# Sistema de Gestión de Productos con Pila

Este proyecto es una aplicación de consola desarrollada en C# que utiliza una estructura de datos de tipo **Pila** (`Stack`) para gestionar una lista de productos. Permite realizar operaciones básicas como agregar, eliminar y consultar productos, simulando un almacén o un inventario simple.

## Funcionalidades

El programa presenta un menú de opciones intuitivo que permite realizar las siguientes acciones:

1.  **Apilar (Agregar) Producto**: Permite al usuario ingresar los datos de un nuevo producto (código, nombre y precio) para agregarlo en la parte superior de la pila.
2.  **Desapilar (Quitar) Producto**: Elimina el producto que se encuentra en el tope de la pila.
3.  **Ver Tope de Pila**: Muestra los datos del producto que se encuentra en la cima de la pila, sin eliminarlo.
4.  **Buscar Producto**: Permite buscar un producto en la pila por su código, mostrando sus detalles si es encontrado.
5.  **Mostrar Pila Completa**: Muestra una lista de todos los productos almacenados en la pila.
6.  **Salir**: Finaliza la ejecución de la aplicación.

## Estructura del Proyecto

El proyecto se compone principalmente de un único archivo:

* `Program.cs`: Contiene toda la lógica de la aplicación, incluyendo:
    * La clase `Producto`, que define los atributos de cada producto (código, nombre y precio).
    * El método `Main`, que ejecuta el menú de opciones en un bucle y gestiona la interacción con el usuario.
    * Métodos para manejar las operaciones de la pila (`Push`, `Pop`, `Peek`, `Contains`).

## Cómo Usar

Para ejecutar la aplicación, sigue estos pasos:

1.  **Clonar el repositorio**:
    ```bash
    git clone [https://github.com/FacundoG-Alarcon/Csharp-Stack-Product-Manager.git]
    ```
2.  Abre el proyecto en tu IDE favorito (como Visual Studio o Visual Studio Code).
3.  Compila y ejecuta la aplicación directamente desde el IDE.

Alternativamente, desde la terminal en la carpeta raíz del proyecto, puedes usar los siguientes comandos:

```bash
# Compilar el proyecto
dotnet build

# Ejecutar el programa
dotnet run
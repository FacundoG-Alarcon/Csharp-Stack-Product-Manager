using DataModel.Pila;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_programacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese cualquier número para mostrar opciones: ");
            Productos productos = new Productos();
            productos.Codigo = 1;
            productos.Descripcion = "";
            productos.Precio = decimal.Parse(Console.ReadLine());
            
            Pila pila = new Pila();
            int salida = 0;

            while (salida != 5)
            {
                Console.WriteLine("Por favor elija la acción");
                Console.WriteLine("1- Agregar elemento a la pila");
                Console.WriteLine("2- Quitar y mostrar elemento de la pila");
                Console.WriteLine("3- Mostrar elemento de la pila con método peek");
                Console.WriteLine("4- Buscar un elemento a partir del código");
                Console.WriteLine("5- Salir");

                int ingreso = int.Parse(Console.ReadLine());
                
                switch (ingreso)
                {

                    case 1:
                        Productos nuevoProducto = new Productos();
                        Console.Write("Ingrese el código del producto: ");
                        nuevoProducto.Codigo = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese la descripción del producto: ");
                        nuevoProducto.Descripcion = Console.ReadLine();
                        Console.Write("Ingrese el precio del producto: ");
                        nuevoProducto.Precio = decimal.Parse(Console.ReadLine());
                        pila.Push(nuevoProducto);
                        Console.WriteLine("Producto agregado a la pila.");
                        break;
                    case 2:
                        Productos productoSacado = pila.Pop();
                        if (productoSacado != null)
                        {
                            Console.WriteLine($"Producto retirado: Código: {productoSacado.Codigo}, Descripción: {productoSacado.Descripcion}, Precio: {productoSacado.Precio}");
                        }
                        else
                        {
                            Console.WriteLine("La pila está vacía.");
                        }
                        break;
                    case 3:
                        Productos productoPeek = pila.Peek();
                        if (productoPeek != null)
                        {
                            Console.WriteLine($"Elemento en la cima: Código: {productoPeek.Codigo}, Descripción: {productoPeek.Descripcion}, Precio: {productoPeek.Precio}");
                        }
                        else
                        {
                            Console.WriteLine("La pila está vacía.");
                        }
                        break;
                    case 4:
                        Console.Write("Ingrese el código del producto a buscar: ");
                        int codigoBuscado = int.Parse(Console.ReadLine());
                        Nodo actual = pila.tope; 
                        bool encontrado = false;

                        while (actual != null)
                        {
                            if (actual.Productos.Codigo == codigoBuscado)
                            {
                                Console.WriteLine($"Producto encontrado: Código: {actual.Productos.Codigo}, Descripción: {actual.Productos.Descripcion}, Precio: {actual.Productos.Precio}");
                                encontrado = true;
                                break;
                            }
                            actual = actual.Siguiente;
                        }

                        if (!encontrado)
                        {
                            Console.WriteLine("Producto no encontrado en la pila.");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Saliendo...");

                        salida = 5;
                        
                        break;
                    default:
                        Console.WriteLine("Opción inválida, por favor intente nuevamente.");
                        break;


                }
            }
        }
    }
}
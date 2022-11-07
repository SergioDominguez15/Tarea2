///////////////////////////////////////////
// Tarea: UD2T2
// Alumno/a: Sergio Dominguez Gomez
// Curso: 2022/2023
///////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tarea2;

namespace Tarea2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;

            try
            {

                do
                {
                    //Opciones a elegir
                    Console.WriteLine("0 - Salir");
                    Console.WriteLine("1 - Crear empleado");
                    Console.WriteLine("2 - Actualizar salario");
                    Console.WriteLine("3 – Mostrar nombre");
                    Console.WriteLine("4 - Mostrar edad");
                    Console.WriteLine("5 - Mostrar empleado");
                    Console.WriteLine("6 - Mostrar empleados");
                    Console.WriteLine("7 – Borrar empleado");
                    Console.Write("Introduzca su opción: ");

                    //Lee la opcion introducida y la guarda en la variable opcion
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        //Sale de la aplicacion
                        case 0:
                            Console.WriteLine("Ha salido de la aplicacion");
                            break;
                        //Añade un nuevo usuario.
                        case 1:
                            Console.WriteLine("Ha elegido crear empleados");
                            Console.Write("Introduzca el nombre: ");
                            string Nombre = Console.ReadLine();
                            Console.Write("Introduzca el primer apellido: ");
                            string Apellido1 = Console.ReadLine();
                            Console.Write("Introduzca el segundo apellido: ");
                            string Apellido2 = Console.ReadLine();
                            Console.Write("Introduzca la edad: ");
                            int Edad = int.Parse(Console.ReadLine());
                            Console.Write("Introduzca el nif: ");
                            string Nif = Console.ReadLine();//
                            Console.Write("Introduzca el salario: ");
                            double Salario = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ha dado de alta a un nuevo usuario");

                            Empleado.NuevoEmpleado(Nombre, Apellido1, Apellido2, Edad, Nif, Salario);
                            Console.WriteLine("Se ha creado un nuevo empleado");
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;
                        //Modifica el salario de un empleado
                        case 2:
                            Console.Write("Introduzca el nif de la persona a modificar: ");
                            string nif = Console.ReadLine();
                            Console.WriteLine($"Salario de dicho empleado: {Empleado.ObtenerEmpleado(nif).Salario}");
                            Console.WriteLine("Introduzca el nuevo salario");
                            double salario = double.Parse(Console.ReadLine());
                            Console.WriteLine("!Salario actualizado!");
                            Empleado.ActualizarSalarioEmpleados(nif, salario);
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;
                        //Muestra el nombre del empleado
                        case 3:
                            Console.Write("Introduzca el nif de la persona a mostrar: ");
                            nif = Console.ReadLine();
                            Console.WriteLine($"El nombre del empleado es: {Empleado.MostrarNombreEmpleado(nif)}");
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;
                        //Mostrar la edad del empleado
                        case 4:
                            Console.Write("Introduzca el nif de la persona a mostrar: ");
                            nif = Console.ReadLine();
                            Console.WriteLine($"La edad del empleado es: {Empleado.MostrarEdadEmpleado(nif)}");
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;
                        //Muestra los datos del empleado
                        case 5:
                            Console.Write("Introduzca el nif de la persona a mostrar: ");
                            nif = Console.ReadLine();
                            Console.WriteLine("Los datos de la persona a mostrar son:");
                            Empleado.MostrarEmpleado(nif);
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;
                        //Muestra los datos de todos los empleados
                        case 6:
                            Console.WriteLine("Muestra todos los empleados: ");
                            Empleado.MostrarEmpleados();
                            Thread.Sleep(4000);
                            Console.Clear();
                            break;
                        //Borra un empleado
                        case 7:
                            Console.Write("Introduzca el nif del empleado a borrar: ");
                            nif = Console.ReadLine();
                            Empleado.BorrarEmpleado(nif);
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;
                        //Si introduce un valor incorrecto le llevara a default
                        default:
                            Console.WriteLine("Introduzca un numero valido");
                            break;
                    }

                } while (opcion != 0);
            }
            catch (FormatException men)
            {
                Console.WriteLine(men.Message);
            }
            catch (OverflowException men)
            {
                Console.WriteLine(men.Message);
            }
        }
    }
}
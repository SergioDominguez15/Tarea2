using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    class Empleado
    {
        string nombre;
        string apellido1;
        string apellido2;
        int edad;
        string nif;
        double salario;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido1
        {
            get { return apellido1; }
            set { apellido1 = value; }
        }
        public string Apellido2
        {
            get { return apellido2; }
            set { apellido2 = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public string Nif
        {
            get { return nif; }
            set { nif = value; }
        }
        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        public Empleado(string nombre, string apellido1, string apellido2, int edad, string nif, double salario)
        {
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.edad = edad;
            this.nif = nif;
            this.salario = salario;
        }

        static List<Empleado> empleados = new List<Empleado>();

        public static void NuevoEmpleado(string nombre, string apellidos, string apellidos2, int edad, string nif, double salario)
        {
            Empleado n = new Empleado(nombre, apellidos, apellidos2, edad, nif, salario);
            empleados.Add(n);
        }

        public static Empleado ObtenerEmpleado(string nif)
        {
            Empleado empleado = null;
            empleado = empleados.FirstOrDefault(e => e.Nif.Equals(nif));
            return empleado;

        }
        public static string MostrarNombreEmpleado(string nif)
        {
            Empleado empleado = ObtenerEmpleado(nif);
            return empleado.nombre;
        }

        public static void ActualizarSalarioEmpleados(string nif, double salario1)
        {
            ObtenerEmpleado(nif).salario = salario1;
        }

        public static int MostrarEdadEmpleado(string nif)
        {
            Empleado empleado = ObtenerEmpleado(nif);
            return empleado.edad;
        }

        public static void MostrarEmpleado(string nif)
        {
            Console.WriteLine($"El nombre es: {Empleado.ObtenerEmpleado(nif).nombre} {Empleado.ObtenerEmpleado(nif).apellido1} {Empleado.ObtenerEmpleado(nif).apellido2}");
            Console.WriteLine($"La edad es: {Empleado.ObtenerEmpleado(nif).edad}");
            Console.WriteLine($"El nif es: {Empleado.ObtenerEmpleado(nif).nif}");
            Console.WriteLine($"El salario es: {Empleado.ObtenerEmpleado(nif).salario}");
        }

        public static void MostrarEmpleados()
        {
            foreach (Empleado empleado in empleados)
            {
                MostrarEmpleado(empleado.nif);
                Console.WriteLine();
                Console.WriteLine("Otro empleado: ");
                Console.WriteLine();
            }
        }

        public static void BorrarEmpleado(string nif)
        {
            empleados.Remove(ObtenerEmpleado(nif));
        }
        public string MuestraNif()
        {
            return this.nif;
        }


    }
}

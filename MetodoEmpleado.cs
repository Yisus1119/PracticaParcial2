using System;
using System.Linq;

namespace PracticaParcial2
{
    class MetodoEmpleado
    {


        string[] nombres = { "Jose Manuel", "Fernando Liriano", "Luis Ramírez", "Pedro López", "Alberto Cruz" };
        int[] sueldos = { 6350, 15500, 17500, 12100, 20000 };

        public void Cargar()
        {
            Console.WriteLine("Lista de empleados y sus respectivos sueldos: ");
            Console.WriteLine("Nombre: {0}. Sueldo: {1}.", nombres[0], sueldos[0]);
            Console.WriteLine("Nombre: {0}. Sueldo: {1}.", nombres[1], sueldos[1]);
            Console.WriteLine("Nombre: {0}. Sueldo: {1}.", nombres[2], sueldos[2]);
            Console.WriteLine("Nombre: {0}. Sueldo: {1}.", nombres[3], sueldos[3]);
            Console.WriteLine("Nombre: {0}. Sueldo: {1}.", nombres[4], sueldos[4]);
            Console.WriteLine(" ");
        }

        public void SalarioMayor()
        {
            int mayor = sueldos.Max();
            Console.WriteLine("El empleado con el salario mayor es: {0} ", nombres[4]);
            Console.WriteLine("Tiene un salario de: {0} ",mayor); 

        }


    }

}
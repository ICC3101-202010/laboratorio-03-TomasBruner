using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee e1 = new Employee();
            Client c1 = new Client();
            Product p1 = new Product();

            Console.WriteLine("Empecemos creando el supermercado");
            Console.WriteLine("Primero ingrese un nombre para este:");
            Console.WriteLine(" ");
            string supermercado = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Bienvenido a " + supermercado);
            Console.WriteLine(" ");
            Console.WriteLine("Antes de comprar en " + supermercado + " hay que crear sus componentes:");
            Console.WriteLine(" ");
            Console.WriteLine("1. Crear empleados");
            Console.WriteLine("2. Cambiarle el sueldo a un empleado");
            Console.WriteLine("3. Crear clientes");
            Console.WriteLine("4. Crear productos");
            Console.WriteLine("5. Pasar a comprar");

            string choice = Console.ReadLine();

            while (choice == "1" || choice == "2" || choice == "3" || choice == "4" || choice == "5")
            {
                if (choice == "1")
                {
                    e1.CreateEmployee();
                }
                else if (choice == "2")
                {
                    e1.ChangeSalary();
                }
                else if (choice == "3")
                {
                    c1.CreateClient();
                }
                else if (choice == "4")
                {
                    p1.CreateProduct();
                }
                else if (choice == "5")
                {
                    Console.WriteLine("Vamos a Comprar");
                    break;
                }
                Console.WriteLine(" ");
                Console.WriteLine("1. Crear empleados");
                Console.WriteLine("2. Cambiarle el sueldo a un empleado");
                Console.WriteLine("3. Crear clientes");
                Console.WriteLine("4. Crear productos");
                Console.WriteLine("5. Pasar a comprar");
                Console.WriteLine(" ");

                choice = Console.ReadLine();
            }

            
            Console.WriteLine(" ");
            Console.WriteLine("Para empezar hay que elegir con que cliente comprar");
            c1.SeeClients();
            c1.SelectClient();
            p1.SeeProducts();
            p1.SelectProduct();
            string respuesta = Console.ReadLine();
            while (true)
            {
                if (respuesta == "si")
                {
                    p1.SeeProducts();
                    p1.SelectProduct();
                }
                else if (respuesta == "no")
                {
                    Console.WriteLine("¿Desea comprar con otro cliente? (si/no)");
                    respuesta = Console.ReadLine();
                    if (respuesta == "no")
                    {
                        Console.WriteLine("Hasta Luego!");
                        break;
                    }
                    else if (respuesta == "si")
                    {
                        c1.SeeClients();
                        c1.SelectClient();
                        p1.SeeProducts();
                        p1.SelectProduct();
                    }
                }
                
                respuesta = Console.ReadLine();
            }
            


            Console.ReadKey();
        }






        
    }

}

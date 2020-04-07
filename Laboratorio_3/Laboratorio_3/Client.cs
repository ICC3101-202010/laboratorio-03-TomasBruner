using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    class Client : Person
    {
        List<string> clients = new List<string>();
        List<string> ruts = new List<string>();
        List<string> names = new List<string>();

        public Client()
        {

        }

        public void CreateClient()
        {
            Console.WriteLine("Ingrese el Rut solo con guión");
            rut = Console.ReadLine();
            if (ruts.Contains(rut))
            {
                Console.WriteLine("Este cliente ya existe");
            }
            else
            {
                ruts.Add(rut);
                Console.WriteLine("Ingrese el nombre");
                name = Console.ReadLine();
                Console.WriteLine("Ingrese el apellido");
                lastname = Console.ReadLine();
                Console.WriteLine("Ingrese la fecha de cumpleaños Dia/Mes/Año");
                dateofbirth = Console.ReadLine();
                Console.WriteLine("Ingrese la nacionalidad");
                nationality = Console.ReadLine();

                names.Add(GetName());
                clients.Add(ClientInformation());
            }
        }

        public string ClientInformation()
        {
             return ("Rut: " + GetRut() + ", Nombre: " + GetName() + ", Apellido: " + GetLastName() + ", Cumpleaños: " + GetDateofbirth() + ", Nacionalidad: " + GetNationality());
        }

         public void SeeClients()
         {
             int i = 0;
             while (i < clients.Count())
             {
                 Console.WriteLine((i + 1) + ". " + clients[i]);
                 i++;
             }
             
         }

        public void SelectClient()
        {
            int decision = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                if (decision < clients.Count() + 1)
                {
                    Console.WriteLine("Que desea comprar con " + names[decision-1] + ":");
                    break;
                }
                else
                {
                    Console.WriteLine("Valor no valido, porfavor ingrese un numero de la lista");
                }
                decision = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void boleta(int decision)
        {
            Console.WriteLine("Boleta de " + names[decision]);
        }
    }
}

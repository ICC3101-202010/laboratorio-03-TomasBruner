using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    class Employee : Person
    {
        private int salary;
        private string role;

        public Employee()
        {

        }
        public string GetRole()
        {
            return role;
        }
        public int GetSalary()
        {
            return salary;
        }

        
        List<string> names = new List<string>();
        List<string> ruts = new List<string>();
        List<string> lastnames = new List<string>();
        List<string> dateofbirths = new List<string>();
        List<string> nationalities = new List<string>();
        List<string> roles = new List<string>();
        List<int> salaries = new List<int>();
        public void CreateEmployee()
        {
            Console.WriteLine("Ingrese el Rut solo con guión");
            rut = Console.ReadLine();
            if (ruts.Contains(rut))
            {
                Console.WriteLine("Este empleado ya existe");
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
                Console.WriteLine("Ingrese el rol");
                role = Console.ReadLine();
                Console.WriteLine("Ingrese el salario");
                salary = Convert.ToInt32(Console.ReadLine());

                names.Add(name);
                lastnames.Add(lastname);
                dateofbirths.Add(dateofbirth);
                nationalities.Add(nationality);
                roles.Add(role);
                salaries.Add(salary);
            }
            
            
        }



        public void SeeEmployees()
        {

            int i = 0;
            while (i < names.Count())
            {
                Console.WriteLine((i + 1) + ". Rut: " + ruts[i]+  " Nombre: " + names[i] + " Apellido: " + lastnames[i] + " Nacimiento: " + dateofbirths[i] + " Nacionalidad: " + nationalities[i] +" Rol: " + roles[i] + " Salario: " + salaries[i]);
                i++;
            }
        }

        public void ChangeSalary()
        {
            SeeEmployees();
            Console.WriteLine("Ingresa el numero en la lista del empleado que le quieres cambiar el sueldo:");
            Console.WriteLine(" ");
            int decision = Convert.ToInt32(Console.ReadLine());
            if (decision < names.Count() + 1)
            {
                Console.WriteLine("Cual será el nuevo salario de " + names[decision - 1]);
                int nuevoSalario = Convert.ToInt32(Console.ReadLine());
                salaries[decision - 1] = nuevoSalario;
            }

        }




    }
}

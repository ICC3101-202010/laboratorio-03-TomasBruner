using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    class Person
    {
        protected string rut;
        protected string name;
        protected string lastname;
        protected string dateofbirth;
        protected string nationality;

        public Person()
        {

        }

        public string GetName()
        {
            return name;
        }
        public string GetRut()
        {
            return rut;
        }
        public string GetLastName()
        {
            return lastname;
        }
        public string GetDateofbirth()
        {
            return dateofbirth;
        }
        public string GetNationality()
        {
            return nationality;
        }

    }
}

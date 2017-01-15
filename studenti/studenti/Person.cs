using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studenti
{
    class Person
    {
        private string _name;
        public string name { get; set; }

        private string _surname;
        public string surname { get; set; }

        private int _age;
        public int age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value <= 0)
                {
                    value = 1;
                }
                _age = value;
            }
        }

        public string cf
        {
            get
            {
                return (name + surname + age);
            }
        }

        public Person (string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public string describe()
        {
            string output = "nome : " + name + "\r\n";
            output += "cognome : " + surname + "\r\n";
            output +=  "anni : " + age + "\r\n";
            output += "codice ficale : " + cf + "\r\n";

            return output;
        }
    } 
}

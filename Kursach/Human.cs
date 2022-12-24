using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Kursach
{
    [Serializable]
    class Human
    {
        private string name;
        private string surname;
        public Human(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public String Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public override string ToString()
        {
            return String.Format("Имя: {0}, Фамилия: {1}", name, surname);
        }
    }
}
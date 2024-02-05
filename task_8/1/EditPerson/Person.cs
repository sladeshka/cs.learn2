using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditPerson
{
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        [NonSerialized]
        int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public override string ToString()
        {
            return Surname + " " + Name + "\nВозраст: " + Age + "\n";
        }
    }
}

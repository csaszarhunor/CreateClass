using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass2
{
    class Person
    {
        private string name;
        private DateTime birthDate;
        private Gender gender;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public Person(){}
        public Person(string name, DateTime birthDate)
        {
            this.Name = name;
            this.BirthDate = birthDate;
        }

        public override string ToString()
        {
            return (String.Format("name: {0}, birth date: {1}", this.name, this.birthDate));
        }

    }

    public enum Gender : int { Male, Female };
}

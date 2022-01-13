using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Version2.Entities
{
    internal class Person:IComparable<Person>
    {
         protected string Name { get; set; }    

        protected string CpfeCnpj { get; set; }

        public Person() { }

        public Person(string name, string cpfecnpj) => (Name, CpfeCnpj) = (name, cpfecnpj);


        public HashSet<Person>ListHash { get; protected set; } = new HashSet<Person>();   

        public  void AddHashList (Person person)
        {

            ListHash.Add(person);
        }

        public override bool Equals(object? obj)
        {
            
            if(!(obj is Person))
            {
                return false;
            }

            Person other = obj as Person;


            return Name == other.Name && CpfeCnpj == other.CpfeCnpj;


        }


        public override int GetHashCode()
        {
            return Name.GetHashCode() + CpfeCnpj.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder display = new StringBuilder();

            display.Append("\nNome: ");
            display.Append(Name);
            display.Append("\nCpf: ");
            display.Append(CpfeCnpj);

            return display.ToString();

        }

        public int CompareTo(Person? other)
        {
           return Name.CompareTo(other.Name);   
        }
    }
}

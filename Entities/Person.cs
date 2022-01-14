using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Version2.Entities
{
    internal class Person:IComparable<Person>
    {
         public  string Name { get; set; }    

        public  string CpfeCnpj { get; set; }

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


            return Name.Equals(other.Name, StringComparison.CurrentCultureIgnoreCase) 
          && CpfeCnpj.Equals(other.CpfeCnpj,StringComparison.CurrentCultureIgnoreCase);

            


        }


        public override int GetHashCode()
        {
            return Name.ToUpper().GetHashCode()+CpfeCnpj.ToUpper().GetHashCode();
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

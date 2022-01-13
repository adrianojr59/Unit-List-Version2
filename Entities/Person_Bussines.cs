using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Version2.Entities
{
    internal class Person_Bussines:Person
    {
        public Person_Bussines(string name, string cpfecnpj) : base(name, cpfecnpj)
        {
             }

        public Person_Bussines() { }

        public  sealed override string ToString(){
            StringBuilder display = new StringBuilder();

            display.Append("\nNome: ");
            display.Append(Name);
            display.Append("\nCpnj: ");
            display.Append(CpfeCnpj);

            return display.ToString();

        }

    }
    }


﻿using List_Version2.Entities;



Person person = new Person();

Person_Bussines _Bussines = new Person_Bussines();

_Bussines.AddHashList(new Person_Bussines("junior", "32328473243284"));

person.AddHashList(new Person("Bob", "323284732432843"));






SortedSet<Person>ListAll = new SortedSet<Person>(person.ListHash);ListAll.UnionWith(_Bussines.ListHash);


var people = ListAll.OrderBy(c => c.CpfeCnpj); // ordernar por cpf e cnpj ou pelo nome 



ListAll.ToList().ForEach(c => c.CpfeCnpj += 22); // adicionar em todos cadastro 22 ao fim  de cada numero ideal para colocar promoção etc




ListView(ListAll);

static void ListView <T>(IEnumerable<T> list)
{
    foreach (T item in list)
    {
        Console.WriteLine(item);
    }
}


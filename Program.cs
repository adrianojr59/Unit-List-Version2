using List_Version2.Entities;



Person person = new Person();

Person_Bussines _Bussines = new Person_Bussines();

_Bussines.AddHashList(new Person_Bussines("junior", "32328473243284"));

person.AddHashList(new Person("Bob", "323284732432843"));






SortedSet<Person>ListAll = new SortedSet<Person>(person.ListHash);ListAll.UnionWith(_Bussines.ListHash);


//var people = ListAll.OrderBy(c => c.CpfeCnpj); // ordernar por cpf e cnpj ou pelo nome 



//ListAll.ToList().ForEach(c => c.CpfeCnpj += 22); // adicionar em todos cadastro 22 ao fim  de cada numero ideal para colocar promoção etc

//List<Person> people = new List<Person>(ListAll.ToList());   // para alterar remover ou fazer qualquer coisa em uma lista precisa sair do tipo baixo nivel e ir para uma lista
//people.RemoveAll(p => p.Name.Length > 2);




ListView(ListAll);

static void ListView <T>(IEnumerable<T> view)
{
    foreach (T item in view)
    {
        Console.WriteLine(item);
    }
}


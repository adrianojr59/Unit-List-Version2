using List_Version2.Entities;



Person person = new Person();

Person_Bussines _Bussines = new Person_Bussines();


person.AddHashList(new Person("bob", "128391239"));
person.AddHashList( new Person("bob", "128324324391239"));


_Bussines.AddHashList(new Person_Bussines("junior","328473243284"));
_Bussines.AddHashList(new Person_Bussines("junior", "32328473243284"));


SortedSet<Person>ListAll = new SortedSet<Person>(person.ListHash);ListAll.UnionWith(_Bussines.ListHash);

ListView(ListAll);

static void ListView <T>(IEnumerable<T> list)
{
    foreach (T item in list)
    {
        Console.WriteLine(item);
    }
}


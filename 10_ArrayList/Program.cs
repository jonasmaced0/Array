using System.Collections;

Console.WriteLine("\n\n ArrayList \n\n");

// construtores:
// ArrayList()
// ArrayList(Int32)
// ArrayList (ICollection)
//

ArrayList lista = new ArrayList();

ArrayList lista1;
lista1 = new ArrayList();
ArrayList lista2 = new();
var lista3 = new ArrayList();

ArrayList lista4;
lista4 = new ArrayList(5);
ArrayList lista5 = new(5);
var lista6 = new ArrayList(5);

ArrayList lista7 = new();

lista7.Add("Paulo");
lista7.Add(4.5);
lista7.Add(5);
lista7.Add(true);
lista7.Add(" ");
lista7.Add(null);

var lista8 = new ArrayList() {"Paulo", 4.5,5, true, " ", null};


Console.ReadKey();

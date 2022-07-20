using System;
using Factory__Pattern__Exercise2;

Console.WriteLine("What type of Database would you like to access?");
Console.WriteLine("Type \"list\" for access of list data");
Console.WriteLine("Type \"sql\" for access to sql data ");
Console.WriteLine("Type \"mongo\" for access to mongo data");

var databaseType = Console.ReadLine();

IDataAccess dataAccessObject = DataAccessFactory.GetDataAccessType(databaseType);
dataAccessObject.SaveData();
var products = dataAccessObject.LoadData();
foreach (var product in products)
{
    Console.WriteLine(product.Name);
    Console.WriteLine(product.Price);
    Console.WriteLine($"\n\n");
}


using csharp_biblioteca;

Users marco = new Users("Marco", "Pietrobono", "marck@gmail.com", "prova1234", "333");

Console.WriteLine(marco.Name);
Console.WriteLine(marco.Surname);
Console.WriteLine(marco.Email);
Console.WriteLine(marco.Password);

Book doc = new Book(23445, "document", 2022, "storia", "1A", "Giacomo", "Leopardi", 245);
Console.WriteLine();

Console.WriteLine(doc.Title);
Console.WriteLine(doc.Year);
Console.WriteLine(doc.Genre);
Console.WriteLine(doc.Position);
Console.WriteLine($"{doc.Author.Name} {doc.Author.Surname}");

Library lib = new Library("La Libreria");
Console.WriteLine();


Console.WriteLine(lib.Name);

Console.WriteLine();

lib.AddDocument(new Dvd(3256343, "Fuga da marea", 2014, "Horror", "1A", "Tom", "Holland", 123));
Console.WriteLine();
lib.allDoc();

Console.WriteLine();

Document query = lib.searchByCode(3256343);
if (query == null)
{
    Console.WriteLine("Non trovato");
}
else
{
    Console.WriteLine("Trovato");
}
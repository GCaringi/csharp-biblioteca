using csharp_biblioteca;

Users marco = new Users("Marco", "Pietrobono", "marck@gmail.com", "prova1234", "333");

Console.WriteLine(marco.Name);
Console.WriteLine(marco.Surname);
Console.WriteLine(marco.Email);
Console.WriteLine(marco.Password);

Book doc = new Book("document", 2022, "storia", "1A", "Giacomo", "Leopardi", 23445, 245);
Console.WriteLine();

Console.WriteLine(doc.Title);
Console.WriteLine(doc.Year);
Console.WriteLine(doc.Genre);
Console.WriteLine(doc.Position);
Console.WriteLine($"{doc.Author.Name} {doc.Author.Surname}");


using System.Text.Encodings.Web;
using System.Text;
using System.Text.Json;
using System.Text.Unicode;
using DZ6;
using System;


try
{
    const string InputPath = @"D:\githw6\DZ6\DZ6\input.json";

    FileStream fs = new FileStream(InputPath, FileMode.OpenOrCreate);

    var books = await JsonSerializer.DeserializeAsync<List<Book>>(fs);




    foreach (var book in books)
    {

        Console.WriteLine($"Title: {book.Title}");
        Console.WriteLine($"Publishing House: {book.PublishingHouse.Name}");
        Console.WriteLine($"Adress: {book.PublishingHouse.Adress}");
        Console.WriteLine();

    }

    fs.Close();

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
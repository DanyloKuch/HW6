using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace HW6
{
    public class Program
    {
        public static void Main()
        {
            try
            {
                string jsonString = File.ReadAllText(@"D:\gitmaui\HW6\HW6\input.json");

                List<Book> books = JsonSerializer.Deserialize<List<Book>>(jsonString);

                foreach (var book in books)
                {
                    Console.WriteLine($"Назва: {book.Title}");
                    Console.WriteLine($"Видавництво: {book.PublishingHouse.Name}");
                    Console.WriteLine($"Адреса: {book.PublishingHouse.Adress}");
                    Console.WriteLine();
                }
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"Помилка десеріалізації JSON: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Інша помилка: {ex.Message}");
            }
        }
    }
}

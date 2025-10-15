using System;


class Program
{
    static void Main(string[] args)
    {
        // Реалізуємо інтерфейс IOperation завдяки класу PbOperatiom (Інтерфейс дає лише сигнатури, класс реалізовує!)
        IOperation phoneBook = new PbOperation();
        while (true)
        {
            System.Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            System.Console.WriteLine("Choose operation:\n1)Add contact;\n2)Delete contact;\n3)Show all contacts;\n4)Find contact by name;\n5)Exit");
            string? operation = Console.ReadLine();
            // Перевірка на те чи передав користувач корректно операцію.
            if (string.IsNullOrEmpty(operation))
            {
                System.Console.WriteLine("Operations cannot be empty. ❗");
                // Якщо користувач введе порожній рядок або null код нижче не виконуємо та повертаємося на початок while 
                continue;
            }
            switch (operation)
            {
                case "1":
                    phoneBook.AddContact();
                    break;
                case "2":
                    phoneBook.DeleteContact();
                    break;
                case "3":
                    phoneBook.ShowAllContacts();
                    break;
                case "4":
                    phoneBook.FindContact();
                    break;
                case "5":
                    System.Console.WriteLine("See you, User.");
                    return;
                default:
                    System.Console.WriteLine("Incorrect operation. ❌");
                    break;
               

            }
        }
    }
}

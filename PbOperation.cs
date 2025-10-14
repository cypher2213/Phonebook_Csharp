public class PbOperation : IOperation
{
    Dictionary<string, string> phoneBook = new Dictionary<string, string>();
   public void AddContact()
    {
        System.Console.WriteLine("Enter the name of contact you want to add:");
        string? name = Console.ReadLine();
        System.Console.WriteLine("Enter the number of contact you want to add (Example: + 380 96 659 14 07)");
        string? number = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(number))
        {
            System.Console.WriteLine("The name or phone can not be empty or invalid. ❌");
            return;
        }
        if (phoneBook.ContainsKey(name))
        {
            System.Console.WriteLine("Contact with that name already exists. ❌");
            return;
        }
        System.Console.WriteLine($"Contact {name} was added successfully. ✅ ");
        phoneBook.Add(name, number);
    }


 
    public void DeleteContact()
    {
        System.Console.WriteLine("Enter the name of the contact you would like to delete.");
        string? name = Console.ReadLine()?.Trim();

        if (string.IsNullOrEmpty(name))
        {
            System.Console.WriteLine("Do not enter empty contact. ❗");
            return;
        }

        if (phoneBook.Remove(name))
        {
            System.Console.WriteLine($"Contact with name {name} deleted. ✅ ");

        }
        else
        {
            System.Console.WriteLine($"No contact with name {name} was found. ❌");
        }
    }
    public void ShowAllContacts()
    {
        int counter = 1;
        if (phoneBook.Count == 0)
        {
            System.Console.WriteLine("Your contact book is empty.");
            return;
        }
        else
        {
            System.Console.WriteLine("\tYour contacts");
            foreach(KeyValuePair<string,string> contact in phoneBook)
            {
                System.Console.WriteLine($"{counter}. {contact.Key} : {contact.Value}");
                counter++;
            }            
        }

    }
    public void FindContact()
    {
        System.Console.WriteLine("Enter the name of contact you would like to find (First letter must be uppercase):");
        string? name = System.Console.ReadLine()?.Trim();
        if (string.IsNullOrEmpty(name))
        {
            System.Console.WriteLine("Do not enter empty contact name. ❗");
            return;
        }
        else if (!phoneBook.ContainsKey(name))
        {
                System.Console.WriteLine($"Contact with name {name} is not found. ❌");
        }
        else
        {
            string number = phoneBook[name];
            System.Console.WriteLine($"Contact with name {name} and number {number} successfully found. ✅");
        }
     
    }
}
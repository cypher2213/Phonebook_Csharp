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

    }
    public void ShowAllContacts()
    {

    }
    public void FindContact()
    {
        
    }
}
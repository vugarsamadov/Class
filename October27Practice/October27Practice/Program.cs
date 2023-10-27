
using October27Practice.Models;

int Size = PromptAndGetInt("Please enter db size: ");

var DataBase = new Notebook[Size];

for(int i = 0; i < Size; i++)
{
    DataBase[i] = GetNotebookFromUser();
}





Notebook GetNotebookFromUser()
{
    var BrandName = PromptAndGetBrandName("Enter brand name: ");
    var ModelName = PromptAndGetString("Enter model name: ");
    var RAM = PromptAndGetRAM("Enter RAM: ");
    var Storage = PromptAndGetInt("Enter storage: ");
    var price = PromptAndGetDecimal("Enter price: ");
    var count = PromptAndGetInt("Enter count: ");

    return new Notebook(count,price,BrandName, ModelName, RAM, Storage);
}

string PromptAndGetString(string prompt)
{
    Console.Write(prompt);
    return Console.ReadLine();
}

string PromptAndGetBrandName(string prompt)
{
    string input;
    do
    {
        Console.Write(prompt);
        input = Console.ReadLine();
        if(input.Length < 3 || input.Length > 30)
        {
            Console.WriteLine("Brand name is invalid!");
        }
    } while (input.Length < 3 || input.Length > 30);

    return input;
}

int PromptAndGetInt(string prompt)
{
    int input;
    do
    {
    Console.Write(prompt);
        input = Convert.ToInt32(Console.ReadLine());
        if (input < 0)
        {
            Console.WriteLine("Input can not be negative!");
        }
    } while (input < 0);
    return input;
}
decimal PromptAndGetDecimal(string prompt)
{
    decimal input;
    do
    {
    Console.Write(prompt);
        input = Convert.ToDecimal(Console.ReadLine());
        if (input < 0)
        {
            Console.WriteLine("Input can not be negative!");
        }
    } while (input < 0);
    return input;
}

int PromptAndGetRAM(string prompt)
{
    int input;
    do
    {
    Console.Write(prompt);
        input = Convert.ToInt32(Console.ReadLine());
        if (input < 0 || input > 128)
        {
            Console.WriteLine("RAM input invalid");
        }
    } while (input < 0 || input > 128);
    return input;
}
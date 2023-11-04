#pragma warning disable CS8602 // Dereference of a possibly null reference.
using November2Practice.Models;
using November2Practice.Utilities.Exceptions;
using November2Practice.Validators;
using System.Reflection;

User s = new User();

string name;
do
{
    Console.Write("Name: ");
    name = Console.ReadLine();
    try
    {
        s.Name = name;
    }
    catch (InvalidNameException x)
    {
        Console.WriteLine(x.Message);
    }
} while (s.Name == null);

string pass;
do
{
    Console.Write("Pass: ");
    pass = Console.ReadLine();
    try
    {
        s.Password = pass;
    }
    catch (InvalidPasswordException x)
    {
        Console.WriteLine(x.Message);
    }
} while (s.Password == null);

string phoneNumber;
do
{
    Console.Write("PhoneNumber: ");
    phoneNumber = Console.ReadLine();
    try
    {
        s.PhoneNumber = phoneNumber;
    }
    catch (InvalidPhoneNumberException x)
    {
        Console.WriteLine(x.Message);
    }
} while (s.PhoneNumber == null);


int age;
do
{
    Console.Write("Age: ");
    age = Convert.ToInt32(Console.ReadLine());
    try
    {
        s.Age = age;
    }
    catch (InvalidAgeExeption x)
    {
        Console.WriteLine(x.Message);
    }
} while (s.Age == 0);




Convert.ToInt16

var assembly = Assembly.GetExecutingAssembly();
var instance = assembly.CreateInstance("November2Practice.ReflectionModels.UseR");

instance.GetType()
    .GetField("_id", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Static)
    .SetValue(instance, 51);


instance.GetType()
    .GetField("_name", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Static)
    .SetValue(instance, "Clinton");
instance.GetType()
    .GetField("_age", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Static)
    .SetValue(instance, 90);

Console.WriteLine(instance);

var method = instance.GetType()
    .GetMethod("ChangeAge", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Static);

method.Invoke(instance,new object[]{4});

Console.WriteLine(instance);



#pragma warning restore CS8602 // Dereference of a possibly null reference.
using October23Practice.Models;

namespace October23Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student()
            {
                Name = "Vugar",
                Age = 20,
                HasScholarship = false,
            };
            
            Student student2 = new Student()
            {
                Name = "Hidayat",
                Age = 20,
                HasScholarship = true,
            };

            Console.WriteLine(student);
            
            Console.WriteLine(student2);
        }
    }
}
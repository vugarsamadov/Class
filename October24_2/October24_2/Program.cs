using Listt;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


IntList a = new IntList();

a.Add(1);
a.Add(2);
a.Print();
a.Add(new int[] {3,4 });
a.Print();
//Console.WriteLine(new Student("Vugar","Samadov",20).Print());

var student = Tuple.Create("Vugar","Samadov");

//Console.WriteLine(student); 

//Console.WriteLine(GetStudent1());

var s = GetStudent2();

Console.WriteLine(s.Item1 +" "+ s.Item2);


(string, string, int) GetStudent1()
{
    var student = ("Vugar", "Samadov", 20);
    return student;
}
Tuple<string,string,int> GetStudent2()
{
    var student = Tuple.Create("Vugar", "Samadov", 20);
    return student;
}

public record Student(string Name, string Surname, int Age)
{
    public string Print()
    {
        return $"{Name} {Surname} {Age}";
    }
}
    






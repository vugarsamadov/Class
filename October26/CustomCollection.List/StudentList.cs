using October26.Model;

namespace CustomCollection.List;

public class StudentList
{
    private Student[] array = new Student[0];

    public void Add(Student student)
    {
        Array.Resize(ref array, array.Length + 1);
        array[array.Length - 1] = student;
    }

    public void Add(Student[] students)
    {
        int OldArrayLength = array.Length;
        Array.Resize(ref array, OldArrayLength + students.Length);
        for (int i = OldArrayLength; i < array.Length; i++)
        {
               array[i] = students[i - OldArrayLength];
        }
    }

    public StudentResultWrapper Get(int index)
    {
        if(index<0)
        {
            Console.WriteLine("Invalid index!");
            return new StudentResultWrapper(false);
        }
        return new StudentResultWrapper(true, array[index]);
    }

    public Student[] GetAll()
    {
        return array;
    }


    public void Print()
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}

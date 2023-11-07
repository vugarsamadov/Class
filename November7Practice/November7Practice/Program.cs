using System.Runtime.CompilerServices;



class Program
{
    delegate int Function(int a, int b);
    public static void Main()
    {
        //Function ExecuteOps = Multiply;
        //ExecuteOps(3,4).Dump();
        
        //ExecuteOps = Sum;
        //ExecuteOps(3,4).Dump();
        
        //ExecuteOps = Subtract;
        //ExecuteOps(3,4).Dump();




    }

    //static int Multiply(int a, int b)
    //{
    //    return a * b;
    //}
    //static int Sum(int a, int b)
    //{
    //    return a + b;
    //}
    //static int Subtract(int a, int b)
    //{
    //    return a - b;
    //}

}


static class Extensions
{
    public static void Dump(this object a)
    {
        Console.WriteLine(a);
    }
}












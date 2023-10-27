using October27.Models;


int command;
do
{
    
    Console.WriteLine(@"
    1.Square
    2.Recatangle
    0.Quit
");
    command = Convert.ToInt32(Console.ReadLine());

    switch (command)
    {
        case 0:
            break;
        case 1:
            Console.Write("Enter side: ");
            var side = Convert.ToInt32(Console.ReadLine());
            if (side == 0)
            {
                Console.WriteLine("Negative side is not allowed");
                break;
            }
            Figure square = new Square(side);
            Console.WriteLine(square.CalcArea());
            break;
        case 2:
            Figure rectangular = new Rectangular(4,5);
            Console.WriteLine(rectangular.CalcArea());
            break;
    }

} while (command != 0);

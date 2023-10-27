using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace October27Practice_2.Models
{
    internal class Dolphin : Fish
    {
        public override void Eat()
        {
            Console.WriteLine("Dolphin is eating");
        }

        public override void Swim()
        {
            Console.WriteLine("Bird is swimming");
        }
        public void PlayWithBall()
        {
            Console.WriteLine("Playing with ball");
        }
    }
}

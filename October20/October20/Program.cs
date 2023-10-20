using October20.Models;
using System;

namespace October20
{
    internal class Program
    {
        static void Main(string[] args)
        {

            FrontEndDeveloper frontEndDeveloper = new FrontEndDeveloper("Adil","N/A",90,9000,
                new string[] { "JS", "JS", "JS" },34444);
           
            frontEndDeveloper.WriteCode();

            BackEndDeveloper backEndDeveloper = new BackEndDeveloper("Vugar", "Samadov", 0, 0,
                new string[] { "Clojure", "Lisp", "C#" }, 34444);
            
            backEndDeveloper.WriteCode();
        }
    }
}

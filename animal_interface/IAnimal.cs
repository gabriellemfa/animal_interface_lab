using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    //Abstract Interface with Name, Colour, Height and Age as members
    public interface IAnimal
    {
        //Declarations:
        string Name { get; set; }
        string Colour { get; set; }
        double Height { get; set; }
        int Age { get; set; }
        void Eat(); //Eat method void type
        string Cry(); //Cry method string type


    }


}
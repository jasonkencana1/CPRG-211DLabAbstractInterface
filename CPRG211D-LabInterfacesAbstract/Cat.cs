using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211D_LabInterfacesAbstract
{
    internal class Cat : Animal, IAnimal
    {
        public Cat(string name, string colour, int age, int height) : base(name, colour, age, height) { }
        public override void Eat()
        {
            Console.WriteLine("Cats eat mice");
        }

        public override void InterfaceEat()
        {
            Console.WriteLine("Cats eat mice");
        }

        public override string Cry()
        {
           return "Meow";
        }

    }
}

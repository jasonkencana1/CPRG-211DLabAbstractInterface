using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211D_LabInterfacesAbstract
{
    internal class Dog : Animal, IAnimal
    {

        public Dog(string name, string color, int age, int height): base (name, color, age, height) 
        {

        }


        public override void Eat()
        {
            Console.WriteLine("Dogs eat meat");
        }

        public override void InterfaceEat()
        {
            Console.WriteLine("Dogs eat meat");
        }

        public override string Cry()
        {
            return "Woof";
        }

    }
}

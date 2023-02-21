using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211D_LabInterfacesAbstract
{
    internal abstract class Animal : IAnimal
    {
        protected string name;
        protected string colour;
        protected int age;
        protected int height;


        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Colour
        {
            get { return this.colour; }
            set { this.colour = value; }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public int Height 
        { 
            get { return this.height; }
            set { this.height = value; } 
        }

        public Animal(string name, string colour, int age, int height)
        {
            this.name = name;
            this.colour = colour;
            this.age = age;
            this.height = height;
        }

        public abstract void Eat();
        public abstract void InterfaceEat();
        public abstract string Cry();
    }
}

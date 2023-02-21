using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211D_LabInterfacesAbstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog("Max", "White", 5, 20);

            dog.Eat();

            Animal cat = new Cat("Mouse", "Black", 4, 15);

            cat.Eat();

            IAnimal interfaceDog = new Dog("Molly", "Brown", 5, 10);

            interfaceDog.InterfaceEat();
            Console.WriteLine(interfaceDog.Cry());

            IAnimal interfaceCat = new Cat("Test", "White", 4, 5);
            interfaceCat.InterfaceEat();
            Console.WriteLine(interfaceCat.Cry());


            Console.Write("Enter Dog name: ");
            string dogName = Console.ReadLine();
            Console.Write("Enter Dog color: ");
            string dogColor = Console.ReadLine();
            Console.Write("Enter dog age: ");
            int dogAge = int.Parse(Console.ReadLine());
            Console.Write("Enter dog height: ");
            int dogHeight = int.Parse(Console.ReadLine());


            IAnimal newDog = new Dog(dogName, dogColor, dogAge, dogHeight );
            newDog.InterfaceEat();
            Console.WriteLine(newDog.Cry());


            Console.Write("Enter Cat name: ");
            string catName = Console.ReadLine();
            Console.Write("Enter Cat color: ");
            string catColor = Console.ReadLine();
            Console.Write("Enter Cat age: ");
            int catAge = int.Parse(Console.ReadLine());
            Console.Write("Enter Cat height: ");
            int catHeight = int.Parse(Console.ReadLine());

            IAnimal newCat = new Cat(catName, catColor, catAge, catHeight);
            newCat.InterfaceEat();
            Console.WriteLine(newCat.Cry());

            List<IAnimal> animals = new List<IAnimal>();
            animals.Add(newCat);
            animals.Add(newDog);
            foreach (IAnimal animal in animals)
            {
                Console.WriteLine(animal.Name);
            }



        }
    }
}

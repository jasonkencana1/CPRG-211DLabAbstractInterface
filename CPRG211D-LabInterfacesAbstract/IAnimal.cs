namespace CPRG211D_LabInterfacesAbstract
{
    internal interface IAnimal
    {
        //properties
        int Age { get; set; }
        string Colour { get; set; }
        string Name { get; set; }
        int Height { get ; set; }


        //methods
        void InterfaceEat();
        string Cry();
    }
}
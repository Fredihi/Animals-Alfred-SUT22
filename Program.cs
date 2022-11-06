using System;

namespace Animals_Alfred_SUT22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat c1 = new Cat(18, 4,"Meat", 7003, 4.5f, 48.3f);
            Manx m1 = new Manx(18, 4, "Meat", 7005, 3.7f, 40f, false);
            Snake s1 = new Snake(true, 0, "Meat", 3004, 1.8f, 8.4f);
            Dog d1 = new Dog(4, 4, "Meat", 2007, 10, 25.7f);
            Sphynx Sph1 = new Sphynx(18, 4, "Meat", 7004, 5.3f, 42.5f, false);

            c1.makeSound();
            c1.Sleep();
            Console.WriteLine();

            s1.makeSound();
            s1.ShedSkin();
            Console.WriteLine();

            m1.makeSound();
            m1.Sleep();
            Console.WriteLine();

            
            d1.makeSound();
            d1.Howl();
            Console.WriteLine();

            Sph1.makeSound();
            Sph1.Sleep();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}

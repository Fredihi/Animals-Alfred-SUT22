using System;
using System.Collections.Generic;
using System.Text;

namespace Animals_Alfred_SUT22
{
    public class Dog : Animals
    {
        public int fangs;
        public Dog(int _fangs, int _legs, string _food, int _animalId, float _weight, float _speed)
        {
            fangs = _fangs;
            legs = _legs;
            food = _food;
            animalId = _animalId;
            weight = _weight;
            speed = _speed;
            sound = "Woof";
        }

        public void Howl()
        {
            Console.WriteLine("The dog howls at the moon remembering it's ancestry from the Wolves.");
        }
        public void makeSound()
        {
            Console.WriteLine(sound);
        }
    }
}

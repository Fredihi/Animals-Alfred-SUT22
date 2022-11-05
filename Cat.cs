using System;
using System.Collections.Generic;
using System.Text;

namespace Animals_Alfred_SUT22
{
    public class Cat : Animals
    {
        public int claws;
        public Cat(int _claws, int _legs, string _food, int _animalId, float _weight, float _speed)
        {
            claws = _claws;
            legs = _legs;
            food = _food;
            animalId = _animalId;
            weight = _weight;
            speed = _speed;
            sound = "Meow";
        }

        public void Sleep()
        {
            Console.WriteLine("Zzzz...");
        }
        public void makeSound()
        {
            Console.WriteLine(sound);
        }
    }
}

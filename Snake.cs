using System;
using System.Collections.Generic;
using System.Text;

namespace Animals_Alfred_SUT22
{
    public class Snake : Animals
    {
        public bool coldblooded;
        public Snake(bool _coldblooded, int _legs, string _food, int _animalId, float _weight, float _speed)
        {
            coldblooded = _coldblooded;
            legs = _legs;
            food = _food;
            animalId = _animalId;
            weight = _weight;
            speed = _speed;
            sound = "SssSsss...";
        }
        public void ShedSkin()
        {
            Console.WriteLine("The snake has shed its skin");
        }
        public void makeSound()
        {
            Console.WriteLine(sound);
        }
    }
}

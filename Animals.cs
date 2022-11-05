using System;
using System.Collections.Generic;
using System.Text;

namespace Animals_Alfred_SUT22
{
    public class Animals
    {
        public string sound;
        public int legs;
        public string food;
        public int animalId;
        public float weight;
        public float speed;
        public void GetLegs()
        {
            Console.WriteLine("The amount of legs the animal has is {0}", legs);
        }

        public void Food()
        {
            Console.WriteLine("The animal eats {0}", food);
        }

        public void Weight()
        {
            Console.WriteLine("The animals weight is {0}", weight);
        }
        

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Animals_Alfred_SUT22
{
    public class Sphynx : Cat
    {
        bool fur;
        public Sphynx(int _claws, int _legs, string _food, int _animalId, float _weight, float _speed, bool Fur) : base(_claws, _legs, _food, _animalId, _weight, _speed)
        {
            fur = Fur;
        }
    }
}

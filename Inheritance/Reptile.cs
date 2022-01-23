using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
                
        }
        public bool HasScales { get; set; }
        public bool IsColdBlooded { get; set; }
        public bool LaysEggs { get; set; }
        public bool EatsBugs { get; set; }
    }
}

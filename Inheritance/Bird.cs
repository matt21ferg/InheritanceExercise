using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            HasFur = false;
            NumberOfLegs = 2;
            HasTail = true;
            CanSwim = false;
        }
   
        public bool HasFeathers { get; set; }
        public bool HasBeak { get; set; }
        public bool CanFly { get; set;}
        public bool HasTalons { get; set; }


    
    
    
    }








}

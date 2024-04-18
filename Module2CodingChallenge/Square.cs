﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2CodingChallenge
{
     class Square : Polygon
    {
        //Attribute
        //Size of the square (four sides are all the same length)
        public float Size { get; set; }

        //Constructors
        public Square(float size)
        { 
            Size = size; // set the value of the attribute to the value of teh argument passed into the constructor
            NumberOfSides = 4; //Sets teh value of the attribute that was inherited from the parent class
        }// end constructor

    }//end class
}// namespace

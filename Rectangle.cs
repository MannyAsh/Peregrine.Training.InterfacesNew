﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesNew
{
     class Rectangle {

        public double height { get; set; }
        public double width { get; set; }

        public double Area() { 

            return height * width;
        }

        public double perimeter() {

            return 2 * height + 2 * width;
        }
    }
}

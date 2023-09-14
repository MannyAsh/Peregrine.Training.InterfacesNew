using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesNew
{
     class Triangle {

        public double bas { get; set; }

        public double height { get; set; }

        

        public double sideOne { get; set; }
        public double sideTwo { get; set; }
        public double sideThree { get; set; }




        public double Area()
        {

            return 0.5 * bas * height;
        }

        public double perimeter()
        {

            return sideOne + sideTwo + sideThree;
        }
    }
}

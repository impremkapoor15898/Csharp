using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    class Dimension
    {
       /// <summary>
       /// Write a pgm that has class dimension and has two co-ordinates x,y and ‘area()’ as virtual 
       /// method.Now write different shape classes such a circle, cylinder and sphere that inherit the
       ///dimension class and calculate the surface area for each of them.Each derived class must have
       ///its own overrided implementation of method ‘area()’. The pgm must display the respective area
       ///of the shapes by implementing the area()
        /// 
        /// </summary>
        float x { get; set; }
        float y{get; set;}
        public virtual string area()
        {
            return $"Area is {this.x * this.y}";
        }


    }
    class circle : Dimension
    {
        public float radius { get; set; }
        public override string area()
        {
            return $"The area of circle is {Math.PI * radius * radius}";
        }
    }
    class cylinder : Dimension
    {
        public float radius { get; set; }
        public float height { get; set; }
        public override string area()
        {
            return $"The surface area of cylinder is {(2*Math.PI * radius * radius)+(2*Math.PI*height)}";
        }
    }
    class sphere : Dimension
    {
        public float radius { get; set; }
        public override string area()
        {
            return $"The surface area of sphere is {4 * Math.PI * radius * radius}";
        }
    }
    class Exer6Day4Test
    {
      public static void Main()
        {
            circle c = new circle { radius = 6 };
            Console.WriteLine(c.area());
            cylinder cy = new cylinder { radius = 6, height = 10 };
            Console.WriteLine(cy.area());
            sphere s = new sphere { radius = 6 };
            Console.WriteLine(s.area());
        }
    }



}

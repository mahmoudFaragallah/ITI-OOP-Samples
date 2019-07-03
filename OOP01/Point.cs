using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP01
{
    class Point
    {
        // A constructor is a special method that is used to initialize a newly created object 
        // and is called just after the memory is allocated for the object 
        // A destructor used to cleanup the stuff when the object is about to die
        int x; // member variable
        int y;
        public int GetX() //Getter for x variable  
        {
            return x;
        }
        public void SetX(int _x) // Stter for x variable
        {
            x = _x;
        }
        public int GetY() // Getter for y variable
        {
            return y;
        }
        public void SetY(int _y)
        {
            y = _y;
        }
        public Point(int _x, int _y) // constructor for Point Class
        {
            x = _x; // set x variable value
            y = _y; // set y variable value
        }
        public Point() // Empty Constructor for Point Class
        {
            x = y = 0;
        }
        public Point(int no) //Constructor for Point Class
        {
            x = y = no;
        }
    }
}

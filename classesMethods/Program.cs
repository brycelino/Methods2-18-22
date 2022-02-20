using System;

namespace classesMethods
{

    class Program
    {
       public static Random random;
        
        static void Main(string[] args)//main
        { 
            random = new Random(); // makes an instance of the random function allows the use of random # generator
            Rectangle r = new Rectangle(); // creates an instance of rectangle allows the use of variables width + height
            
            int min = 0; // controls the minimum amount the random generator can choose from
            int max = 100; // sets the maximum amount the random generator can choose from

            MakeRectangle( min, max,out r.Height, out r.Width); // creates an instance of MakeRectangle returns the min,max,hieght, and width
            
           

            Console.WriteLine("Height: " + r.Height); // Displays the Height on screen
            Console.WriteLine("Width: " + r.Width); // Displays the Width on Screen
            Console.WriteLine("Area " + MathUtility.AreaFormula(r)); // Displays the area of the width and height on screen
            Console.WriteLine("Area " + MathUtility.PerimeterFormula(r)); // displays the perimeter of the width and height on screen

        }
        public class Rectangle// Class for rectangle that holds the width and hieght 
        {
            public int Height; //  int that holds the hieght
            public int Width; // int that contains the width

            public Rectangle() // constructor for rectangle class that assigns the hieght and width a value 
            {
                Height = 3; // value for hieght 
                Width = 10; // value for width 
            }
        }
        
        public class MathUtility // class for the forumla of area and perimeter

        {
            public static int AreaFormula( Rectangle r) // Function for area accepts the parameter rectangle r to allow the use of variables width and height
            {
                
               return r.Height * r.Width; // formula for area 
                
            }

            public static int PerimeterFormula(Rectangle r) // Function for perimeter accepts the parameter rectangle r to allow the use of variables width and height
            {
                
                return 2 * (r.Height + r.Width); // Formula for perimeter
                
            }
        }
        public static void MakeRectangle(int min, int max, out int Height, out int Width) // Function that accepts parameter min and max and gives out the width and height
        {
            Rectangle r = new Rectangle(); // Instance that allows the use of the width and height 
           
            Height = r.Height; // Declares height from parameter
            Width = r.Width; // Declares width from parameter
            Height = random.Next(min, max); // allows the use of random number generator for Height that accepts min and max 
            Width = random.Next(min, max);// allows the use of random number generator for Width that accepts min and max 
        }

    }
}
    
using System;

namespace classesMethods
{

    class Program
    {

        public static Random random;
        static void Main(string[] args)//main
        {
            Rectangle r = new Rectangle();

           
          

            Console.WriteLine(r.Height);
            Console.WriteLine(r.Width);

           
            
        }
        public class Rectangle// Class for rectangle that holds the width and hieght 
        {
            public int Height; //  int that holds the hieght
            public int Width; // int that contains the width

            public Rectangle() // constructor for rectangle class that assigns the hieght and width a value 
            {
                Height = 0; // value for hieght 
                Width = 0; // value for width 
            }
        }
        public class MathUtility // class for the forumla of area and perimeter

        {
            public static void AreaFormula(int area)
            {
                Rectangle r = new Rectangle();

                area = r.Height * r.Width;
               
            }
            public static void PerimeterFormula(int perimeter)
            {
                Rectangle r = new Rectangle();

                perimeter = 2 * (r.Height + r.Width);
            }
        }
        public static void MakeRectangle(int min, int max, out int Height, out int Width)
        {
           
           Rectangle r = new Rectangle();
            Height = r.Height;
            Width = r.Width;
            Height = random.Next(0, 100);
            Width = random.Next(0, 100);
        }
        
    }
}
    


/*
random = new Random();
           int a = 0;
           int b = 0;

           Console.WriteLine(a);
           Console.WriteLine(b);

           getRandomValues(out a, out b);

           Console.WriteLine(a);
           Console.WriteLine(b);
 static void getRandomValues(out int n1, out int n2
 n1 = random.Next(0, 100);
            n2 = random.Next(0, 5);
 static int Add(int n1,int n2)
return n1 + n2;
   CSCS
   */


namespace basic.ConsoleApp1
{

    class Program
    {

        static void Main()
        {

            Rectangle r = new Rectangle();

            r.Acceptdetails();
            r.Display();

            //To get the exact size of a type or a variable on a particular platform

            Console.WriteLine("Size of int: {0}", sizeof(int));

            Console.WriteLine("Size of int: {0}", sizeof(float));

            Console.WriteLine("Size of int: {0}", sizeof(double));

            Console.WriteLine("Size of int: {0}", sizeof(char));




        }


        class Rectangle
        {

            // member variables
            double length;
            double width;

            // evaluation length and width
            public void Acceptdetails()
            {
                length = 4.5;
                width = 3.5;
            }
            public double GetArea()
            {
                return length * width;
            }
            public void Display()
            {
                Console.WriteLine("Length: {0}", length);
                Console.WriteLine("Width: {0}", width);
                Console.WriteLine("Area: {0}", GetArea());
            }
        }



    }

}
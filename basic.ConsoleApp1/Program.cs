

namespace basic.ConsoleApp1
{

    class Program
    {

        static void Main()
        {

            Rectangle r = new Rectangle();

            r.Acceptdetails();
            r.Display();


        }


        class Rectangle
        {

            // member variables
            double length;
            double width;

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
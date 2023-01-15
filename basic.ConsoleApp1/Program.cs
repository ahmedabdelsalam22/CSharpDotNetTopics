

namespace basic.ConsoleApp1
{

    class Program
    {

        static void Main()
        {

            Rectangle r = new Rectangle();
            r.Acceptdetails();
            r.Display();

           // To get the exact size of a type or a variable on a particular platform
            Console.WriteLine("Size of int: {0}", sizeof(int));
            Console.WriteLine("Size of int: {0}", sizeof(float));
            Console.WriteLine("Size of int: {0}", sizeof(double));
            Console.WriteLine("Size of int: {0}", sizeof(char));

           // Object Type
            object obj;
            obj = 15;
            Console.WriteLine(obj);


            // var VS dynamic
            var name = "Ahmed";
            Console.WriteLine(name);

            // dynamic
            dynamic num = 15;
            Console.WriteLine(num);
            num = "Mohamed";
            Console.WriteLine(num);


            // Type conversion :- type casting 

            double d = 5673.74;
            int i =  (int)d; // convert d (double) to i (int)

            Console.WriteLine(d);
            Console.WriteLine(i);




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
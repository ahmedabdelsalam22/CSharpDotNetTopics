

using System;
using System.Reflection.Metadata;
using System.Transactions;
using System.Xml.Linq;

namespace basic.ConsoleApp1
{

    class Program
    {

        static void Main()
        {


            //Rectangle r = new Rectangle();
            //r.Acceptdetails();
            //r.Display();

            //// To get the exact size of a type or a variable on a particular platform
            //Console.WriteLine("Size of int: {0}", sizeof(int));
            //Console.WriteLine("Size of int: {0}", sizeof(float));
            //Console.WriteLine("Size of int: {0}", sizeof(double));
            //Console.WriteLine("Size of int: {0}", sizeof(char));

            //// Object Type
            //object obj;
            //obj = 15;
            //Console.WriteLine(obj);


            //// var VS dynamic
            //var name = "Ahmed";
            //Console.WriteLine(name);

            //// dynamic
            //dynamic num = 15;
            //Console.WriteLine(num);
            //num = "Mohamed";
            //Console.WriteLine(num);


            //// Type conversion :- type casting 
            //double d = 5673.74;
            //int i =  (int)d; // convert d (double) to i (int)
            //Console.WriteLine(d);
            //Console.WriteLine(i);

            //// Type conversion :- type casting 
            //int i = 75;
            //float f = 53.005f;
            //double d = 2345.7652;
            //bool b = true;
            //Console.WriteLine(i.ToString());
            //Console.WriteLine(f.ToString());
            //Console.WriteLine(d.ToString());
            //Console.WriteLine(b.ToString());


            //// Accepting Values from User
            //Console.WriteLine("Hi,Enter Your num");
            //int num;
            //num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("your number is equal "+num);


            //// Defining Constants
            //// how to get areaCircle  
            //const double pi = 3.14;
            //double r;
            //Console.WriteLine("Please, Enter Radius: ");
            //r = Convert.ToDouble(Console.ReadLine());
            //double areaCircle = pi * r * r;
            //Console.WriteLine("Radius: {0}, Area: {1}", r, areaCircle);


            //// Declation array ////Initializing an Array during the declaration.
            //double[] balance = {15000.0 , 18000.0 , 22000.0};          
            //// Assigning Values to an Array 
            //balance[0] = 12000.0;
            //balance[1] = 17000.0;
            //balance[2] = 22000.0;
            //// display array
            //Console.WriteLine(balance[0]);
            //Console.WriteLine(balance[1]);
            //Console.WriteLine(balance[2]);


            //// You can also create and initialize an array, as shown 
            //int[] marks = new int[] {5,8,14} ;

            //Console.WriteLine(marks[0]);
            //Console.WriteLine(marks[1]);
            //Console.WriteLine(marks[2]);

            //// You can copy an array variable into another target array variable
            // int[] score = marks;

            //Console.WriteLine(score[0]);
            //Console.WriteLine(score[1]);
            //Console.WriteLine(score[2]);


            //// display array with for loop

            //for (int i=0; i<marks.Length; i++) 
            //{
            //    Console.WriteLine("marks[{0}] = {1}" , i, marks[i]);
            //}



            //// intialize array with for loop
            //int[] grade = new int[5];
            //for (int i=0; i<grade.Length; i++) {
            //    Console.WriteLine("Enter array number with index {0}", i);
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    grade[i] = num;
            //}
            //Console.WriteLine("***********************");
            ////// display array after insert items in it 
            //for (int i = 0; i < grade.Length; i++)
            //{
            //    Console.WriteLine("marks[{0}] = {1}", i, grade[i]);
            //}



            /////Encapsulation

            ///// Public Access Specifier
            //Rectangle r1 = new Rectangle();
            //r1.length= 10;
            //r1.width=15;
            //Console.WriteLine(r1.getArea());

            ///// private Access Specifier
            // Rectangle r1 = new Rectangle();
            //r1.getArea();


            //string firtsName, lastName;
            //firtsName = "Rowan ";
            //lastName = "Atkinson";

            //string fullname = firtsName + lastName;
            //Console.WriteLine("Full Name: {0}", fullname);

            //char[] letters = { 'H', 'e', 'l', 'l', 'o' };
            //////by using string constructor { 'H', 'e', 'l', 'l','o' };
            //string greetings = new string(letters);
            //Console.WriteLine("Greetings: {0}", greetings);

            //methods returning string { "Hello", "From", "Tutorials", "Point" };
            //string[] greeting = { "Hello", "From", "Tutorials", "Point" };
            //string message = String.Join(" ", greeting);
            //Console.WriteLine("Message: {0}", message);

            ////formatting method to convert a value
            //DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
            //string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
            //Console.WriteLine("Message: {0}", chat);

            //string str1 = "This is text";
            //string str2 = "This is text";

            //if (String.Compare(str1, str2) == 0)
            //{
            //    Console.WriteLine(str1 + " and " + str2 + " are equal.");
            //}
            //else
            //{
            //    Console.WriteLine(str1 + " and " + str2 + " are not equal.");
            //}

            //string str = "This is test";

            //if (str.Contains("test"))
            //{
            //    Console.WriteLine("The sequence 'test' was found.");
            //}

            //string str = "Last night I dreamt of San Pedro";
            //Console.WriteLine(str);
            //string substr = str.Substring(23);
            //Console.WriteLine(substr);

            //string[] starray = new string[]{"Down the way nights are dark",
            //"And the sun shines daily on the mountain top",
            //"I took a trip on a sailing ship",
            //"And when I reached Jamaica",
            //"I made a stop"};

            //string str = String.Join("\n", starray);
            //Console.WriteLine(str);

            
      

        }




        // struct 

        struct Books { 
        

        
        }




        //// public access Specifier
        //class Rectangle {
        //    public double length;
        //    public double width;

        //    public double getArea() {
        //        return length * width;
        //    } 
        //}




        //class Rectangle
        //{

        //    private double length;
        //    private double width;

        //    public void getArea()
        //    {
        //        Console.WriteLine("Enter Rectangle Length");
        //        length = Convert.ToDouble(Console.ReadLine());
        //        Console.WriteLine("Enter Rectangle Width");
        //        width = Convert.ToDouble(Console.ReadLine());

        //        double area = length * width;
        //        Console.WriteLine("Rectanlge area is equal " + area);
        //    }


        //}



        //class Rectangle
        //{

        //    // member variables
        //    double length;
        //    double width;

        //    // evaluation length and width
        //    public void Acceptdetails()
        //    {
        //        length = 4.5;
        //        width = 3.5;
        //    }
        //    public double GetArea()
        //    {
        //        return length * width;
        //    }
        //    public void Display()
        //    {
        //        Console.WriteLine("Length: {0}", length);
        //        Console.WriteLine("Width: {0}", width);
        //        Console.WriteLine("Area: {0}", GetArea());
        //    }
        //}


    }











}
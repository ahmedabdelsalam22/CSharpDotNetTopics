

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

            // using struct Books
            //Books Book1;   /* Declare Book1 of type Book */
            //Books Book2;   /* Declare Book2 of type Book */

            ///* book 1 specification */
            //Book1.title = "C Programming";
            //Book1.author = "Omer Ali";
            //Book1.subject = "C Programming Tutorial";
            //Book1.book_id = 6495407;

            ///* print Book1 info */
            //Console.WriteLine("Book 1 title : {0}", Book1.title);
            //Console.WriteLine("Book 1 author : {0}", Book1.author);
            //Console.WriteLine("Book 1 subject : {0}", Book1.subject);
            //Console.WriteLine("Book 1 book_id :{0}", Book1.book_id);

            ///* book 2 specification */
            //Book2.title = "Telecom Billing";
            //Book2.author = "Zara Ali";
            //Book2.subject = "Telecom Billing Tutorial";
            //Book2.book_id = 6495700;

            ///* print Book2 info */
            //Console.WriteLine("Book 2 title : {0}", Book2.title);
            //Console.WriteLine("Book 2 author : {0}", Book2.author);
            //Console.WriteLine("Book 2 subject : {0}", Book2.subject);
            //Console.WriteLine("Book 2 book_id : {0}", Book2.book_id);


            //Books Book1 = new Books();   /* Declare Book1 of type Book */
            //Books Book2 = new Books();   /* Declare Book2 of type Book */

            ///* book 1 specification */
            //Book1.getValues("C Programming",
            //"Nuha Ali", "C Programming Tutorial", 6495407);


            ///* print Book1 info */
            //Book1.display();

            ///* book 2 specification */
            //Book2.getValues("Telecom Billing",
            //"Zara Ali", "Telecom Billing Tutorial", 6495700);

            ///* print Book2 info */
            //Book2.display();

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

            // using struct Books
            //Books Book1;   /* Declare Book1 of type Book */
            //Books Book2;   /* Declare Book2 of type Book */

            ///* book 1 specification */
            //Book1.title = "C Programming";
            //Book1.author = "Omer Ali";
            //Book1.subject = "C Programming Tutorial";
            //Book1.book_id = 6495407;

            ///* print Book1 info */
            //Console.WriteLine("Book 1 title : {0}", Book1.title);
            //Console.WriteLine("Book 1 author : {0}", Book1.author);
            //Console.WriteLine("Book 1 subject : {0}", Book1.subject);
            //Console.WriteLine("Book 1 book_id :{0}", Book1.book_id);

            ///* book 2 specification */
            //Book2.title = "Telecom Billing";
            //Book2.author = "Zara Ali";
            //Book2.subject = "Telecom Billing Tutorial";
            //Book2.book_id = 6495700;

            ///* print Book2 info */
            //Console.WriteLine("Book 2 title : {0}", Book2.title);
            //Console.WriteLine("Book 2 author : {0}", Book2.author);
            //Console.WriteLine("Book 2 subject : {0}", Book2.subject);
            //Console.WriteLine("Book 2 book_id : {0}", Book2.book_id);


            //Books Book1 = new Books();   /* Declare Book1 of type Book */
            //Books Book2 = new Books();   /* Declare Book2 of type Book */

            ///* book 1 specification */
            //Book1.getValues("C Programming",
            //"Nuha Ali", "C Programming Tutorial", 6495407);


            ///* print Book1 info */
            //Book1.display();

            ///* book 2 specification */
            //Book2.getValues("Telecom Billing",
            //"Zara Ali", "Telecom Billing Tutorial", 6495700);

            ///* print Book2 info */
            //Book2.display();

            //int WeekdayStart = (int)Days.Mon;
            //int WeekdayEnd = (int)Days.Fri;

            //Console.WriteLine("Monday: {0}", WeekdayStart);
            //Console.WriteLine("Friday: {0}", WeekdayEnd);


            //Box Box1 = new Box();   // Declare Box1 of type Box
            //Box Box2 = new Box();

            //double volume = 0.0;

            //// box 1 specification
            //Box1.height = 5.0;
            //Box1.length = 6.0;
            //Box1.breadth = 7.0;


            //// box 2 specification
            //Box2.height = 10.0;
            //Box2.length = 12.0;
            //Box2.breadth = 13.0;



            //// volume of box 1
            //volume = Box1.height * Box1.length * Box1.breadth;
            //Console.WriteLine("Volume of Box1 : {0}", volume);

            //// volume of box 2
            //volume = Box2.height * Box2.length * Box2.breadth;
            //Console.WriteLine("Volume of Box2 : {0}", volume);

            // box 1 specification
            //Box1.setLength(6.0);
            //Box1.setBreadth(7.0);
            //Box1.setHeight(5.0);

            //// box 2 specification
            //Box2.setLength(12.0);
            //Box2.setBreadth(13.0);
            //Box2.setHeight(10.0);

            //// volume of box 1
            //volume = Box1.getVolume();
            //Console.WriteLine("Volume of Box1 : {0}", volume);

            //// volume of box 2
            //volume = Box2.getVolume();
            //Console.WriteLine("Volume of Box2 : {0}", volume);

            // set line length

            //Line line = new Line();

            //line.setLength(6.0);
            //Console.WriteLine("Length of line : {0}", line.getLength());

            //Line line = new Line(10.0);
            //Console.WriteLine("Length of line : {0}", line.getLength());

            //  Line line = new Line();

            //StaticVar s1 = new StaticVar();
            //StaticVar s2 = new StaticVar();

            //s1.count();
            //s1.count();
            //s1.count();

            //s1.count();
            //s1.count();
            //s1.count();


            ////Console.WriteLine("Variable num for s1: {0}", s1.getNum());
            ////Console.WriteLine("Variable num for s2: {0}", s2.getNum());
            //StaticVar s = new StaticVar();

            //s.count();
            //s.count();
            //s.count();

            //Console.WriteLine("Variable num: {0}", StaticVar.getNum());

            //Rectangle Rect = new Rectangle();

            //Rect.setWidth(5);
            //Rect.setHeight(7);

            //// Print the area of the object.
            //Console.WriteLine("Total area: {0}", Rect.getArea());

            //Tabletop t = new Tabletop(4.5, 7.5);
            //t.Display();


            //Rectangle Rect = new Rectangle();
            //int area;

            //Rect.setWidth(5);
            //Rect.setHeight(7);
            //area = Rect.getArea();

            //// Print the area of the object.
            //Console.WriteLine("Total area: {0}", Rect.getArea());
            //Console.WriteLine("Total paint cost: ${0}", Rect.getCost(area));

            //Printdata p = new Printdata();

            //// Call print to print integer
            //p.print(5);

            //// Call print to print float
            //p.print(500.263);

            //// Call print to print string
            //p.print("Hello C++");

            //Rectangle r = new Rectangle(10, 7);
            //double a = r.area();
            //Console.WriteLine("Area: {0}", a);

            Caller c = new Caller();
            Rectangle r = new Rectangle(10, 7);
            Triangle t = new Triangle(10, 5);

            c.CallArea(r);
            c.CallArea(t);


        }

    }






        public override int area()
        {
            Console.WriteLine("Rectangle class area :");
            return (width * height);
        }
    }

    class Triangle : Shape
    {
        public Triangle(int a = 0, int b = 0) : base(a, b)
        {
        }
        public override int area()
        {
            Console.WriteLine("Triangle class area :");
            return (width * height / 2);
        }
    }

    class Caller
    {
        public void CallArea(Shape sh)
        {
            int a;
            a = sh.area();
            Console.WriteLine("Area: {0}", a);
        }
    }


    //abstract class Shape
    //{
    //    public abstract int area();
    //}

    //class Rectangle : Shape
    //{
    //    private int length;
    //    private int width;

    //    public Rectangle(int a = 0, int b = 0)
    //    {
    //        length = a;
    //        width = b;
    //    }

    //    public override int area()
    //    {
    //        Console.WriteLine("Rectangle class area :");
    //        return (length*width);
    //    }
    //}

    //class Printdata
    //{
    //    public void print(int i)
    //    {
    //        Console.WriteLine("Printing int: {0}", i);
    //    }
    //    public void print(double f)
    //    {
    //        Console.WriteLine("Printing float: {0}", f);
    //    }
    //    public void print(string s)
    //    {
    //        Console.WriteLine("Printing string: {0}", s);
    //    }
    //}


    //class Shape
    //{
    //    public void setWidth(int w)
    //    {
    //        width = w;
    //    }
    //    public void setHeight(int h)
    //    {
    //        height = h;
    //    }
    //    protected int width;
    //    protected int height;
    //}

    //// Base class PaintCost
    //public interface PaintCost
    //{
    //    int getCost(int area);
    //}

    //class Rectangle : Shape, PaintCost
    //{

    //    public int getArea()
    //    {
    //        return (width * height);
    //    }

    //    public int getCost(int area)
    //    {
    //        return area * 70;
    //    }

    //}


    //class Rectangle
    //{

    //    //member variables
    //    protected double length;
    //    protected double width;

    //    public Rectangle(double l, double w)
    //    {
    //        length = l;
    //        width = w;
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


    //class Tabletop : Rectangle
    //{
    //    public Tabletop(double l, double w) : base(l, w)
    //    {

    //    }

    //    public double GetCost()
    //    {
    //        double cost;
    //        cost = GetArea() * 70;
    //        return cost;
    //    }

    //    public void Display()
    //    {
    //        base.Display();
    //        Console.WriteLine("Cost: {0}", GetCost());
    //    }

    //}



    //class Shape {

    //    protected int width;
    //    protected int height;

    //    public void setWidth(int w)
    //    {
    //        width = w;
    //    }
    //    public void setHeight(int h)
    //    {
    //        height = h;
    //    }

    //}

    //// Derived class

    //class Rectangle : Shape
    //{
    //    public int getArea()
    //    {
    //        return (width * height);
    //    }
    //}


    //class StaticVar
    //{
    //    public static int num;

    //    public void count()
    //    {
    //        num++;
    //    }
    //    public static int getNum()
    //    {
    //        return num;
    //    }
    //}

    //class Line
    //{
    //    private double length;

    //    public Line()
    //    {
    //        Console.WriteLine("Object is being created");
    //    }

    //    //public Line(double len)
    //    //{  //Parameterized constructor
    //    //    Console.WriteLine("Object is being created, length = {0}", len);
    //    //    length = len;
    //    //}

    //    ~Line()
    //    {   //destructor
    //        Console.WriteLine("Object is being deleted");
    //    }

    //    public void setLength(double len)
    //    {
    //        length = len;
    //    }

    //    public double getLength()
    //    {
    //        return length;
    //    }

    //}

    //class Box
    //{
    //    public double length;   // Length of a box
    //    public double breadth;  // Breadth of a box
    //    public double height;   // Height of a box

    //    public void setLength(double len)
    //    {
    //        length = len;
    //    }
    //    public void setBreadth(double bre)
    //    {
    //        breadth = bre;
    //    }
    //    public void setHeight(double hei)
    //    {
    //        height = hei;
    //    }

    //    public double getVolume()
    //    {
    //        return length * breadth * height;
    //    }

    //}


    //enum Days { Sun, Mon, tue, Wed, thu, Fri, Sat };





    // struct 

    //struct Books {

    //    public string title;
    //    public string author;
    //    public string subject;
    //    public int book_id;


    //    public void getValues(string t, string a, string s, int id)
    //    {
    //        title = t;
    //        author = a;
    //        subject = s;
    //        book_id = id;
    //    }


    //    public void display()
    //    {
    //        Console.WriteLine("Title : {0}", title);
    //        Console.WriteLine("Author : {0}", author);
    //        Console.WriteLine("Subject : {0}", subject);
    //        Console.WriteLine("Book_id :{0}", book_id);
    //    }

    //}





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












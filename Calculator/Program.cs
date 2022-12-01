namespace Calculator
{
    public class calculator // accessmodifier class keyword  class name ( class declaration)
    {
        //int a ;//state -data and variable declaration
        //int b ;
       //int c;

       public int Add(int a, int b)//fxn declaration with code body and called functionality//(<access modifier> <return type> <method name>(parameter list))
        {
            return a + b;
            //Console.WriteLine("sum of two given no is : "+c);
            //Console.ReadLine();
        }
        public int Subtract(int a, int b)//fxn declaration with code body and called functionality
        {
            return a - b;
        }
        int Multiply(int a, int b)//fxn declaration with code body and called functionality private
        {
            return a*b;
        }
        //    // --------------------------recursion method example-----------------p
        //    int n;
        //    public void counting()
        //    {
        //        int n = 1;
        //        if (n == 10)
        //            return;// for exit the fxn
        //        Console.WriteLine(n);
        //        n++;
        //        counting();
        //    }
        //    int num = 5;//5*4*
        //    int result = 1;
        //    int factorial() // with recursion method
        //    {
        //        if (num == 0)
        //        { return 1; }

        //        result = result * num;
        //        num--;
        //        factorial();
        //        return result;

        //    }


        //    //-----------------------------------------------------------------------
        public static void Main(string[] args)
        {
            //Console.WriteLine("object creation");
            calculator obj = new calculator();//object creation (nameof class refrence name new(created and memory located) classname()(constructor))
            Console.WriteLine("enter ist no");
            int a = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("enter 2nd no");
            int b = Convert.ToInt32(Console.ReadLine());

            //obj.a = 20;
            //obj.b = 30;
            Console.WriteLine("sum of given no is: "+obj.Add(a,b));
            Console.WriteLine("sub of given no is: "+obj.Subtract(a,b));
            Console.WriteLine("Product of given no is: " + obj.Multiply(a, b));
            Console.ReadLine();
            //
            //calculator obj2 = new calculator(); //multiple object creation
            //obj2.a = 40;
            //obj2.b = 50;
            //obj2.Add();
            //obj2.Subtract();
            //obj.counting();
            //int c = obj.factorial();
            // Console.WriteLine( obj.factorial());
        }


    }
        //class program
        //{
        //    static void Main(string[] args)
        //    {
        //        //Console.WriteLine("object creation");
        //        //calculator obj = new calculator();//object creation (nameof class refrence name new(created and memory located) classname()(constructor))
        //        //obj.a = 20;
        //        //obj.b = 30;
        //        //obj.Add();
        //        //obj.Subtract();
        //        //
        //        //calculator obj2 = new calculator(); //multiple object creation
        //        //obj2.a = 40;
        //        //obj2.b = 50;
        //        //obj2.Add();
        //        //obj2.Subtract();
        //        //obj.counting();
        //        //int c = obj.factorial();
        //        //Console.WriteLine(obj.factorial());


        //        //---------------------------------------------------------
        //        MyClass obj=new MyClass();
        //        //obj.Name = raj;//because class variables are declared in private accessifier so we cannot access it by another class main

        //    }
        //}

        //+++++++++++++++++++++++++++++++++++++++++++class and access modifier+++++++++++++++++++++++++++++
        //class MyClass
        //{
        //string Name; //private variable declaration
        //int std;
        //int fees;

        //void display() //private method which called within class main
        //{
        //    Console.WriteLine("Name of students: " +Name);
        //    Console.WriteLine("Standard: "+std);
        //    Console.WriteLine("fees: "+fees);
        //}
        ////********************************** by public access modifier*************************
        //public string firstName; //public variable declaration
        //public string lastame;
        //public int salary;
        //public void show() //public method which called from any where within namespace
        //{
        //    Console.WriteLine("FirstName: " + firstName);
        //    Console.WriteLine("LastName: " + lastame);
        //    Console.WriteLine("Salary: " + salary);
        //}
        //****************************************************************************************

        ////--------------------within class main for executing private data menbers of class--------
        //static void Main(string[] args)
        //{
        //        MyClass obj= new MyClass();
        //    obj.Name="RajshriPriya";
        //    obj.std = 15;
        //    obj.fees = 50000;
        //    obj.display();
        //}
    

    //**for public accessfier we can access the data member from any where with in same namespace by"different classes main also"**************

    //class program
    //{
    //    static void Main(string[] args)
    //    {
    //        MyClass obj=new MyClass();
    //        obj.firstName = "rajshri";
    //        obj.lastame = "priya";
    //        obj.salary = 80000;
    //        obj.show();
    //    }
    //}
}
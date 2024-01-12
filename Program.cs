using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{

    interface I1
    {
        void print1();
    }


    interface I2
    {
        void print2();
    }

    public class MyClass : I1, I2
    {
        public void print1()
        {
            Console.WriteLine("1");
        }

        public void print2()
        {
            Console.WriteLine("2");
        }
    }











    //interface I1
    //{
    //   void print1();
    //}

    //interface I2:I1
    //{
    //    void print2();
    //}


    //interface I3:I2
    //{
    //    void print3();
    //}




    public class Program  //:I3
    {




        






        //public void print1()
        //{
        //    Console.WriteLine("Print 1 ");
        //}

        //public void print2()
        //{
        //    Console.WriteLine("Print 2 ");
        //}

        //public void print3()
        //{
        //    Console.WriteLine("Print 3 ");
        //}

        static void Main(string[] args)
        {
            //Program program = new Program();
            //program.print1();
            //program.print2();
            //program.print3();
            //Console.ReadLine();

            MyClass myClass = new MyClass();
            myClass.print1();


        }


    }
}

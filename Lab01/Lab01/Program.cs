
using System;

namespace ConsoleApp5
{

    class Program
    {

        static void Main(string[] args)
        {
            Person p = new Person();
            p.SayHi();
            Student s = new Student();
            s.SayHi();
            Person sp = new Student();
            sp.SayHi();
            Teacher t = new Teacher();
            t.SayHi();
            Person tp = new Teacher();
            tp.SayHi();
            Console.ReadKey();
        }

    }
    class Vector
    {
        public Vector(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public int X { get; set; }  // X - accessor (property)
        public int Y { get; set; }  // Y - accessor (property)

        public override string ToString()
        {
            return string.Format("({0},{1})", X, Y);
        }
        // All operator overloads must be public and static.
        public static Vector operator +(Vector v1, Vector v2) //binary operator +
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y);
        }
        public static Vector operator -(Vector v1)  //unary operator -
        {
            return new Vector(-v1.X, -v1.Y);
        }
    }

    class Person
    {
        public virtual void SayHi()
        {
            Console.WriteLine("Hi I'm a person");
        }
    }

    class Student : Person
    {
        public override void SayHi()
        {
            Console.WriteLine("Hi I'm a student");
        }
    }

    class Teacher : Person
    {
        public new void SayHi()
        {
            Console.WriteLine("Hi I'm a teacher");
        }
    }

}



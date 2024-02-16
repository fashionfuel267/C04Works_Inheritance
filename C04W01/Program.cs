using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C04W01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var annClass = new {Name="Tasnim", Age=23 };

            Console.WriteLine( $"Name:{ annClass.Name} Age: {annClass.Age}");
            string msg = "";
            int z = 0;
            GetMessage("Hello",out msg);
            Console.WriteLine(  msg);
            int result= GetData(52, 3,out z);
            Console.WriteLine(  $"remainder of {52}&{3}: {result}, divisor of  {52}&{3}: {z}");
            int r = 0;
            GetData(ref r);
            Console.WriteLine($"ref example: {r}");
            Circle c = new Circle(5);
            c.Area();
            Rectangle rect = new Rectangle(5,6);
            rect.Area();
            Shape shape = rect;

            Console.ReadKey();
        }
        static void GetMessage( string m, out string data)
        {
            data = m.ToLower();
            Console.WriteLine(  m.ToUpper());
        }
        public static int GetData(int x, int y, out int z)
        {
            z = x / y;
            return x % y;
        }
        public static void GetData(ref int x )//method overloading
        {
            x=60;
        }
    }
    public class A { 

    }

    public abstract class Shape
    {
        int _r ;
        protected int h;
        public Shape( )
        {
            
        }
        public Shape(int r) { this._r = r; }
        public virtual void Area()
        {
            Console.WriteLine(Math.PI * _r * _r);
        }

    }
    public sealed class  Circle:Shape//base
    {
        public Circle(int r):base(r)
        { }

    }
    public class Rectangle:Shape {
        int _l, _w;
        public Rectangle(int l,int w)  {
            this._l = l;
            this._w = w;
        }
        public override void Area()
        {
            h = 0;
            Console.WriteLine(_l*_w);
        }
    }
    //public class c : Circle { }

}

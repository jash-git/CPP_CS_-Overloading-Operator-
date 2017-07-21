using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Overloading_Operator
{
    public class point2D
    {
        public int m_x;
        public int m_y;
        public point2D(int x,int y)
        {
            m_x = x;
            m_y = y;
        }
        public point2D()
        {
            m_x = 0;
            m_y = 0;
        }
        public static bool operator ==(point2D T, point2D U)
        {
            bool Ans = false;
            if((U.m_x==T.m_x) && (U.m_y == T.m_y))
            {
                Ans = true;
            }
            return Ans;
        }
        public static bool operator !=(point2D T, point2D U)
        {
            bool Ans = true;
            if ((U.m_x == T.m_x) && (U.m_y == T.m_y))
            {
                Ans = false;
            }
            return Ans;
        }
    }
    class Program
    {
        static void pause()
        {
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
        static void Main(string[] args)
        {
            point2D A = new point2D();
            point2D B = new point2D();
            point2D C = new point2D(10,20);
            Console.WriteLine("A(" + A.m_x + "," + A.m_y + ")");
            Console.WriteLine("B(" + B.m_x + "," + B.m_y + ")");
            Console.WriteLine("C(" + C.m_x + "," + C.m_y + ")");
            if(A==B)
            {
                Console.WriteLine("A=B");
            }
            else
            {
                Console.WriteLine("A!=B");
            }
            if (A == C)
            {
                Console.WriteLine("A=C");
            }
            else
            {
                Console.WriteLine("A!=C");
            }
            pause();
        }
    }
}

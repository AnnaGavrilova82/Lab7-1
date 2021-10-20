using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер ребра куба = ");
            int a = Convert.ToInt32(Console.ReadLine());
            CalcVolume(a);
           // CalcPloshad(a);
            Console.ReadKey();
        }
        static void CalcVolume(int a)
            
        {
            int V = a * a * a;
            int S = 6 * a * a;
            Console.WriteLine("Объем куба равен {0}", V);
            Console.WriteLine("Объем куба равен {0}", S);
            Console.ReadKey();
        }
        
	    
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_строки
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] strArray = str.Split();
            string word = "";
            int z = 0;
            foreach (String s in strArray)
            {
                if (s.Length > z)
                {
                    word = s;
                    z = s.Length;
                }
            }
                        Console.WriteLine(word);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int DT = DateTime.Now.Hour;
            if(DT>=6 && DT<=12)
            {
                Console.WriteLine("Günaydın");
            }
           else if(DT>12 & DT<18)
                {
                Console.WriteLine("İyi Günler");
            }
            else
            {
                Console.WriteLine("İyi Geceler");
            }
            string sonuc = DT >= 6 && DT <= 12 ? "Günaydın" : DT > 12 & DT < 18 ? "İyi Günler" : "İyi geceler";
            Console.WriteLine(sonuc);
            Console.Read();
        }
    }
}

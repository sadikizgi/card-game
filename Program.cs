using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13042016_week7
{
    class Program
    {
        static void Main(string[] args)
        {
            KartDestesi kartDestem = new KartDestesi();
            kartDestem.Karma(); 
            
            for (int i = 0; i < 52; i++)
            {
                Console.Write("{0,-19}", kartDestem.KartDagitma());
                
                if ((i + 1) % 4 == 0)
                        Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Man
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("Msk,10", 100, 15, 20);
            Console.WriteLine(building.Print());
            Multibuilding multibuilding = new Multibuilding("Spb,20", 50, 12, 30, 9); 
            Console.WriteLine(multibuilding.Print()); 
            
            Console.ReadKey();
        }
    }
}

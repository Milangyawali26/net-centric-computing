using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11_milan_26806
{
    class framework
    {
        public string version;
        public framework()
        {
            this.version = "4.7.9";
        }
    }
    class version : framework
    {
        public string framework;
        public version() : base()
        {

            this.framework = "Dot.net";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            version v = new version();
            Console.WriteLine("The Framework is " + v.framework);

            Console.WriteLine("The version is " + v.version);
            Console.ReadLine();
        }
        
    }
    
}

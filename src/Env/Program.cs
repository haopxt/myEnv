using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Env
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string machine = Environment.MachineName;
            int cpus = Environment.ProcessorCount;
            Console.WriteLine(machine +"---"+cpus);
            Console.ReadKey();
        }
    }
}

using System;
using BuilderPattern;
using Director;

namespace Executor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectorClass director = new();

            director.Builder = new Nvidia4070TiDesktopGPUBuilder();

            director.BuildStandardProduct();

            var GPU = director.Builder.GPU;
            
            director.BuildPremiumProduct();

            var NewGPU = director.Builder.GPU;
            Console.WriteLine();
        }
    }
}

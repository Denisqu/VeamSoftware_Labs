using System;
using VeamSoftware_Labs.Veam_module_1.lb4;

namespace VeamSoftware_Labs
{
    class Program
    {
        static void Main(string[] args)
        {
            ExcerciseOne.PrintResult();
            ExcerciseTwo.GetException();
            Console.ReadKey();
            ExcerciseTwo.GetException();
            ExcerciseTwo.ThrowCatchedException();
            Console.ReadKey();
        }
    }
}

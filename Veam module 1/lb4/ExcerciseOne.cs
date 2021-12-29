using System;
using System.Text;
namespace VeamSoftware_Labs.Veam_module_1.lb4
{
    public class ExcerciseOne
    {
        public static void PrintResult()
        {
            string eng = "Das ist eine sehr deutsche Saite";
            string ru = "Это русская строка";
            string jp = "これは日本語の文字列です";

            
            var bytes = Encoding.Unicode.GetBytes(ru);

            Console.WriteLine(Encoding.Unicode.GetString(bytes));

            bytes = Encoding.Unicode.GetBytes(eng);
            
            Console.WriteLine(Encoding.Unicode.GetString(bytes));

            bytes = Encoding.UTF8.GetBytes(jp);

            Console.WriteLine(Encoding.UTF8.GetString(bytes));

        }

    }
    
    
    
}
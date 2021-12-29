using System;
using System.Runtime.ExceptionServices;
namespace VeamSoftware_Labs.Veam_module_1.lb4
{
    public class ExcerciseTwo
    {

        private static ExceptionDispatchInfo catchedException;
        
        public static void GetException()
        {
            try
            {
                int[] ar = new int[3];
                ar[3]++;
            }
            catch(Exception e)
            {
                catchedException = ExceptionDispatchInfo.Capture(e);
            }
        }

        public static void ThrowCatchedException()
        {
            catchedException.Throw();
        }
    }
}


/*
*
 * Задание 2
Используйте ExceptionDispatchInfo для регистрации исключения в одном месте программы и
вызова этого исключения в другом месте программы с помощью метода
ExceptionDispatchInfo.Throw
*
*/
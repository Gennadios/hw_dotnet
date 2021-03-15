using System;

namespace HW._08.Task4
{
    class Program
    {
        static int lesson = 9;
        const double Pi = 3.14;

        static void Main(string[] args)
        {
            /*
             * According to Microsoft C# documentation const keyword is used to declare a constant field.
             * const is static by default and static modifier is not allowed for its declaration.
             * 
             * It is confirmed by Microsoft documentation, ECMA C# specification and analysis of IL code that
             * const indeed is a static field. Screenshots can be found at 'Assets' folder.
             */
        }
    }
}

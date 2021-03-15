using System;
using AssemblyOne;

namespace AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Motorcycle moto2 = new Motorcycle(); --- Motorcycle is internal, so only works in AssemblyOne

            PublicMotorcycle publicmoto = new PublicMotorcycle();

            // publicmoto.Start(); --- Start() is private, therefore it's only accessible within definition of Motorcycle
            // publicmoto.InternalStart(); --- can only be accessed within the same asssembly
            publicmoto.PublicStart();
            // publicmoto.ProtectedStart(); --- can be accessed only within the same class, or in a class which was derived from it
            // publicmoto.PrivateProtectedStart(); --- can only be accessed within the original class or within inherited class AND within the same assembly
            // publicmoto.InternalProtectedStart(); --- can be accessed either in the same assembly OR within inherited class, meets neither of the conditions
        }
    }
}

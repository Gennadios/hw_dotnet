using System;

namespace AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle moto = new Motorcycle();

            // moto.Start(); --- Start() is private, therefore it's only accessible within definition of Motorcycle
            moto.InternalStart();
            moto.PublicStart();
            // moto.ProtectedStart(); --- can be accessed only within the same class, or in a class which was derived from it
            // moto.PrivateProtectedStart(); --- can only be accessed within the original class or within inherited class AND within the same assembly
            moto.InternalProtectedStart();

            PublicMotorcycle pmoto = new PublicMotorcycle();
            // all the method calls will work the same way
        }
    }
}

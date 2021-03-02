using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyOne
{
    internal class Motorcycle //internal by default
    {
        private void Start() => Console.WriteLine("Vroom"); // private by default, only accessible within the definition of Motorcycle

        internal void InternalStart() => Console.WriteLine("Vroom (internally)");

        public void PublicStart() => Console.WriteLine("Vroom (publicly)");

        protected void ProtectedStart() => Console.WriteLine("Vroom (protected)");

        private protected void PrivateProtectedStart() => Console.WriteLine("Vroom (private protected)");

        internal protected void InternalProtectedStart() => Console.WriteLine("Vroom (internal protected)");

        // everything will work here as its within the class definition (basically, within the curly braces)
        private void ClassScopeCall()
        {
            Start();
            InternalStart();
            PublicStart();
            ProtectedStart();
            PrivateProtectedStart();
            InternalProtectedStart();
        }
    }
}

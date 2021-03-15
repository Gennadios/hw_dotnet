using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyOne
{
    public class PublicMotorcycle
    {
        private void Start() => Console.WriteLine("VRRROOOM");

        internal void InternalStart() => Console.WriteLine("VRRROOOM (internally)");

        public void PublicStart() => Console.WriteLine("VRRROOOM (publicly)");

        protected void ProtectedStart() => Console.WriteLine("VRRROOOM (protected)");

        private protected void PrivateProtectedStart() => Console.WriteLine("VRRROOOM (private protected)");

        internal protected void InternalProtectedStart() => Console.WriteLine("VRRROOOM (internal protected)");

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

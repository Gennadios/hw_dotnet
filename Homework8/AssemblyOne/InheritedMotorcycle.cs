using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyOne
{
    class InheritedMotorcycle : Motorcycle
    {
        private void InheritedClassScopeCall()
        {
            // Start(); --- no access to this one, because Start() is private for the parent class Motorcycle
            InternalStart();
            PublicStart();
            ProtectedStart();
            PrivateProtectedStart();
            InternalProtectedStart();
        }
    }
}

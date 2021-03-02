using System;
using System.Collections.Generic;
using System.Text;
using AssemblyOne;

namespace AssemblyTwo
{
    class InheritedMotorcycle2 : PublicMotorcycle
    {
        private void OutsideAssemblyScope()
        {
            // Start(); --- will not work, because accessible only within AssemblyOne Motorcycle class scope
            // InternalStart(); --- will not work, because accessible only within AssemblyOne
            PublicStart();
            ProtectedStart();
            // PrivateProtectedStart(); --- cannot be accessed, because it's outside of its declaring assembly
            InternalProtectedStart();
        }
    }
}

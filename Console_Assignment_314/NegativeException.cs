using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Assignment_314
{
    public  class NegativeException : Exception
    {
        public NegativeException ()
            : base() {  }
        public NegativeException(string message)
            : base() {  }
    }
}

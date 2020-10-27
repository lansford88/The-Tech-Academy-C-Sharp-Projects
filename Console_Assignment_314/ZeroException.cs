using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Assignment_314
{
    class ZeroException : Exception
    {
        public ZeroException()
            : base() { }
        public ZeroException(string message)
            : base() { }
    }
}

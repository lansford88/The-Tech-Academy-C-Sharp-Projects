using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Assignment_248
{
    public class Employee <T>       // makes Employee a Generic Class
    {
        public int Id { get; set; }

        public List<T> Things       // Matches the generic datatype to the class datatype
        { get; set; }
     }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Console_Assignment_310_Const_Var_ChainPractice
{
    class MotorCycle
    {
        public string model;
        public string color;


        public MotorCycle(string modelName) : this(modelName, "Red")
        {
        }

        public MotorCycle(string modelName, string modelcolor)
        {
            color = modelcolor;
            model = modelName;
        }


    }
}

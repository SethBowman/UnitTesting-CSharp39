using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject
{
    public class Helper
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        public string Greeting(string name)
        {
            if(string.IsNullOrEmpty(name))
            {
                return "Hello!";
            }

            return $"Hello, {name}!";
        }
    }
}

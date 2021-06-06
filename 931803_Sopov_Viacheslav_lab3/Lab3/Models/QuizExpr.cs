using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3.Models
{
    public class QuizExpr
    {
        public int number1 {get;set;}
        public int number2 { get; set; }
        public string op { get; set; }
        public int Ans { get; set; }
        public int rightAnswer { get; set; }
        public void Count()
        {
            if (op == "+")
            {
                rightAnswer = number1 + number2;
            }
            else if (op == "-")
            {
                rightAnswer = number1 - number2;
            }
        }
    }
}

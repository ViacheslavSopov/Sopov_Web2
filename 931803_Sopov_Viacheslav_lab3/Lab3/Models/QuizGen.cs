using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3.Models
{
    public class QuizGen
    {
        Random rnd = new Random();
        public int num1 { get; set; }
        public int num2 { get; set; }
        public string operation { get; set; }
        public List<QuizExpr> Expressions { get; set; } = new List<QuizExpr>();
        public void Gen()
        {
            num1 = rnd.Next(0, 10);
            num2 = rnd.Next(0, 10);
            if(rnd.Next(0,2) == 0)
            {
                operation = "+";
            }
            else { operation = "-"; }
        }
    }
}

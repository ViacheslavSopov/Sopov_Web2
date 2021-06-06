using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab3.Models;

namespace Lab3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Quiz()
        {
            QuizGen quiz = new QuizGen();
            quiz.Gen();
            return View(quiz);
        }

        [HttpPost]
        public IActionResult Quiz(QuizGen quiz, int UserAnswer, string action)
        {
            if (!ModelState.IsValid)
            {
                return View(quiz);
            }
            QuizExpr expr = new QuizExpr();
            if (action == "Next")
            {
                expr.Ans = UserAnswer;
                quiz.Gen();
                expr.number1 = quiz.num1;
                expr.number2 = quiz.num2;
                expr.op = quiz.operation;
                expr.Count();
                quiz.Expressions.Add(expr);
                return View(quiz);
            }
            else
            {
                expr.Ans = UserAnswer;
                expr.number1 = quiz.num1;
                expr.number2 = quiz.num2;
                expr.op = quiz.operation;
                expr.Count();
                quiz.Expressions.Add(expr);
                return View("Result", quiz);
            }
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

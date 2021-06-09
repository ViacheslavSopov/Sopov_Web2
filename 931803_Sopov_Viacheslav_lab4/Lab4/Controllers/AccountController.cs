using Microsoft.AspNetCore.Mvc;
using Lab4.Models;

namespace Lab4.Controllers
{
    public class AccountController : Controller
    {

        [HttpGet]
        public IActionResult ResetPassword()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ResetPassword(ResetModel model, string action)
        {
            if (model.Code == null)
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }
                if (action == "Send")
                {
                    model.Message = "We have sent you a code";
                    return View("ResetContinue", model);
                }
                else
                {
                    model.Message = "";
                    return View("ResetContinue", model);
                }
            }
            else { return View("ResetEnd"); }
        }

        [HttpGet]
        public IActionResult SignUpFirst()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUpFirst(SignUpModel model)
        {
            if (model.Email == null)
            {
                return View("SignUpSecond", model);
            }
            else
            {
                if (!ModelState.IsValid)
                {
                    return View("SignUpSecond", model);
                }
                else { return View("SignUpResult", model); }
            }
        }
    }
}
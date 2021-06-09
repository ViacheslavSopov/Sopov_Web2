using Microsoft.AspNetCore.Mvc;
using Lab4.Models;

namespace Lab4.Controllers
{
    public class ControlsController : Controller
    {
        [HttpGet]
        public IActionResult TextBox()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TextBox(string TB)
        {
            ControlModel cm = new ControlModel
            {
                ControlElement = "Text Box",
                Result = TB,
                Name = "Text: "
            };
            return View("ResultControl", cm);
        }

        [HttpGet]
        public IActionResult TextArea()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TextArea(string TA)
        {
            ControlModel cm = new ControlModel
            {
                ControlElement = "Text Area",
                Result = TA,
                Name = "Text: "
            };
            return View("ResultControl", cm);
        }

        [HttpGet]
        public IActionResult CheckBox()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CheckBox(bool isSelected)
        {
            ControlModel cm = new ControlModel
            {
                ControlElement = "Check Box",
                Name = "isSelected"
            };
            if (isSelected == false)
            {
                cm.Result = "False";
            }
            else
            {
                cm.Result = "True";
            }
            return View("ResultControl", cm);
        }


        [HttpGet]
        public IActionResult RadioButton()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RadioButton(string month)
        {
            ControlModel cm = new ControlModel
            {
                ControlElement = "Radio",
                Result = month,
                Name = "Month: "
            };
            return View("ResultControl", cm);
        }

        [HttpGet]
        public IActionResult DropDownList()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DropDownList(string month)
        {
            ControlModel cm = new ControlModel
            {
                ControlElement = "Drop-Down List",
                Result = month,
                Name = "Month: "
            };
            return View("ResultControl", cm);
        }

        [HttpGet]
        public IActionResult ListBox()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ListBox(string month)
        {
            ControlModel cm = new ControlModel
            {
                ControlElement = "List Box",
                Result = month,
                Name = "Month: "
            };
            return View("ResultControl", cm);
        }
    }
}
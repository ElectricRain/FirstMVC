using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVC.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public string Index()
        {
            return "This is Index action method of StudentController";
        }
    }
}
using CoreForStudent.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreForStudent.Controllers
{
    public class HomeController:Controller
    {
        private readonly IStudentRepository _studentRepository;

        public HomeController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public   IActionResult Index()
        {
            var model =  _studentRepository.GetStudent(1);
            return Ok();
        }
        public IActionResult GetStudent()
        {
            string s = "sss";
            return View();
        }
    }
}
